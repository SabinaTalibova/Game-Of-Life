using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameofLife_Test
{
    public partial class Form1 : Form
    {
        private const int button_dim = 14;
        private const int grid_dim = 700;
        private const int numof_cells = grid_dim / button_dim;


        int[,] engine;


        public Form1()
        {
            InitializeComponent();
            engine = new int[numof_cells, numof_cells];


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i + button_dim <= grid_dim; i += button_dim)
            {
                for (int j = 0; j + button_dim <= grid_dim; j+= button_dim)
                {
                    Button cell_Button = new Button();
                    cell_Button.Size = new Size(button_dim, button_dim);
                    cell_Button.Location = new Point(i, j);
                    cell_Button.Click += new EventHandler(ClickCell);
                    cell_Button.FlatStyle = FlatStyle.Flat;
                    cell_Button.BackColor = Color.Black;
                    cell_Button.FlatAppearance.BorderColor = Color.Black;
                    cell_Button.FlatAppearance.BorderSize = 1;
                    grp_grid.Controls.Add(cell_Button);
                    


                }
            }
        }

        private void ClickCell(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Black":
                    ctrl.BackColor = Color.Green;
                    break;
                case "Green":
                    ctrl.BackColor = Color.Black;
                    break;

                default:
                    ctrl.BackColor = Color.Red;
                    break;


            }




        }
    }

}

         

   

