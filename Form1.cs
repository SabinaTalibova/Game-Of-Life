
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;


namespace GameOfLife
{

    public partial class Life_form : Form
    {
        //defining initial vaues of grid
        int button_dim=14;
        int grid_dim=700;
        int num_of_cells_h=50;
        int num_of_cells_w=50;

        Color alive_cell_Color = Color.Green;
        Color dead_cell_Color = Color.Black;




        private GameOfLife life = null;

        public Life_form()

        {
            InitializeComponent();
            life = new GameOfLife(num_of_cells_h, num_of_cells_w);
        }

        //This function is called once form loads
        public void Life_Load(object sender, EventArgs e)
        {
            //for loop goes through grid and adds button to every cordinate specified in for loop
            for (int j = 0; j + button_dim <= grid_dim; j += button_dim)
                for (int i = 0; i + button_dim <= grid_dim; i += button_dim)
                {
                    Button newButton = new Button();
                    newButton.Size = new Size(button_dim, button_dim);
                    newButton.Location = new Point(i, j);
                    newButton.FlatStyle = FlatStyle.Flat;
                    newButton.Click += new EventHandler(ClickCell);
                    grid.Controls.Add(newButton);
                }

            UpdateColours();
        }
        //this function is called when every cell(button) on grid is clicked
        private void ClickCell(object sender, EventArgs e)
        {
            //user will not be able to click cell if timer is enabled
            if (timer1.Enabled)
                return;
            //this part of the code finds location of button 
            int index = grid.Controls.IndexOf(sender as Control);
            int y = index / life.width;
            int x = index % life.width;
            //here we check value of button and change it 
            if (life[y, x] == true)
            {
                life[y, x] = false;
            }
            else
            {
                life[y, x] = true;
            }
            //based on valus we change color of cell
            
            ((Button)sender).BackColor = life[y, x] ? alive_cell_Color : dead_cell_Color;
        }

        //this function changes the color of cell depending on the state of cell
        //For ex: if cell is dead ehis will change color to black and vice verca
        private void UpdateColours()
        {
            for (int num_of_cells = 0; num_of_cells < grid.Controls.Count; ++num_of_cells)
                grid.Controls[num_of_cells].BackColor =
                    life[num_of_cells / life.width, num_of_cells % life.width] ? alive_cell_Color : dead_cell_Color;
        }

        //whenever timer is enables New Generation function from GameOfLife will be called
        //and Based on cell's state update function will change color of cells
        private void timer1_Tick(object sender, EventArgs e)
        {
            life.NewGeneration();
            UpdateColours();
        }

        //this function is called when 'Start' button is pressed
        private void btn_start_Click(object sender, EventArgs e)
        {
            //we will enable timer so that New generation will be creaetd
            timer1.Enabled = true;
            //we need to disable start button because it has already been pressed
            btn_start.Enabled = false;
            //we need to enable stop so we can stop the simulation
            btn_stop.Enabled = true;
        }

        //this function is called when 'Stop' button is pressed
        private void btn_stop_Click(object sender, EventArgs e)
        {
            //we need to stop timer so it will stop creating new generation
            timer1.Enabled = false;
            //we need to disable stop button because it has already been pressed
            btn_stop.Enabled = false;
            //we need to enable start so we can start the simulation again
            btn_start.Enabled = true;
        }


        //this function is called when 'Step' button is pressed
        private void btn_onestep_Click(object sender, EventArgs e)
        {
            //it calls newGeneration function only once
            life.NewGeneration();
            UpdateColours();
        }

        //this function is called when 'Clear' button is pressed
        private void btn_clear_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btn_stop.Enabled = false;
            btn_start.Enabled = true;
            //new 'life' will be created with initial empty values so grid is empty
            life = new GameOfLife(life.height, life.width);

            UpdateColours();
        }

        //remaning part of the code is to help to change the color of dead and alive cells
        private void btn_red_Click(object sender, EventArgs e)
        {
            alive_cell_Color = Color.Red;
        }

        private void btn_blue_Click(object sender, EventArgs e)
        {
            alive_cell_Color = Color.Blue;
        }

        private void btn_yellow_Click(object sender, EventArgs e)
        {
            alive_cell_Color = Color.Yellow;
        }

        private void btn_purple_Click(object sender, EventArgs e)
        {
            alive_cell_Color = Color.Purple;
        }

        private void btn_dimgrey_Click(object sender, EventArgs e)
        {
            dead_cell_Color = Color.DimGray;
        }

        private void btn_azure_Click(object sender, EventArgs e)
        {
            dead_cell_Color = Color.Azure;
        }

        private void btn_choco_Click(object sender, EventArgs e)
        {
            dead_cell_Color = Color.Chocolate;
        }

        private void btn_grey_Click(object sender, EventArgs e)
        {
            dead_cell_Color = Color.Gray;
        }

     

       
    }
}