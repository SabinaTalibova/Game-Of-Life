namespace GameOfLife
{
    partial class Life_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grid = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_onestep = new System.Windows.Forms.Button();
            this.txt_alive = new System.Windows.Forms.Label();
            this.btn_red = new System.Windows.Forms.Button();
            this.btn_purple = new System.Windows.Forms.Button();
            this.btn_yellow = new System.Windows.Forms.Button();
            this.btn_blue = new System.Windows.Forms.Button();
            this.btn_azure = new System.Windows.Forms.Button();
            this.btn_choco = new System.Windows.Forms.Button();
            this.btn_grey = new System.Windows.Forms.Button();
            this.btn_dimgrey = new System.Windows.Forms.Button();
            this.txt_dead = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Location = new System.Drawing.Point(135, 12);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(700, 700);
            this.grid.TabIndex = 0;
            this.grid.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(31, 65);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 35);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(31, 144);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 35);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(31, 106);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 32);
            this.btn_stop.TabIndex = 6;
            this.btn_stop.Text = "STOP";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_onestep
            // 
            this.btn_onestep.Location = new System.Drawing.Point(31, 185);
            this.btn_onestep.Name = "btn_onestep";
            this.btn_onestep.Size = new System.Drawing.Size(75, 23);
            this.btn_onestep.TabIndex = 7;
            this.btn_onestep.Text = "STEP";
            this.btn_onestep.UseVisualStyleBackColor = true;
            this.btn_onestep.Click += new System.EventHandler(this.btn_onestep_Click);
            // 
            // txt_alive
            // 
            this.txt_alive.AutoSize = true;
            this.txt_alive.Location = new System.Drawing.Point(-1, 259);
            this.txt_alive.Name = "txt_alive";
            this.txt_alive.Size = new System.Drawing.Size(133, 13);
            this.txt_alive.TabIndex = 8;
            this.txt_alive.Text = "Change Color of Alive cells";
            // 
            // btn_red
            // 
            this.btn_red.BackColor = System.Drawing.Color.Red;
            this.btn_red.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_red.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_red.ForeColor = System.Drawing.Color.Red;
            this.btn_red.Location = new System.Drawing.Point(12, 275);
            this.btn_red.Name = "btn_red";
            this.btn_red.Size = new System.Drawing.Size(19, 18);
            this.btn_red.TabIndex = 9;
            this.btn_red.Text = "button1";
            this.btn_red.UseVisualStyleBackColor = false;
            this.btn_red.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // btn_purple
            // 
            this.btn_purple.BackColor = System.Drawing.Color.Purple;
            this.btn_purple.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_purple.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_purple.ForeColor = System.Drawing.Color.Red;
            this.btn_purple.Location = new System.Drawing.Point(87, 275);
            this.btn_purple.Name = "btn_purple";
            this.btn_purple.Size = new System.Drawing.Size(19, 18);
            this.btn_purple.TabIndex = 10;
            this.btn_purple.UseVisualStyleBackColor = false;
            this.btn_purple.Click += new System.EventHandler(this.btn_purple_Click);
            // 
            // btn_yellow
            // 
            this.btn_yellow.BackColor = System.Drawing.Color.Yellow;
            this.btn_yellow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_yellow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_yellow.ForeColor = System.Drawing.Color.Red;
            this.btn_yellow.Location = new System.Drawing.Point(62, 275);
            this.btn_yellow.Name = "btn_yellow";
            this.btn_yellow.Size = new System.Drawing.Size(19, 18);
            this.btn_yellow.TabIndex = 11;
            this.btn_yellow.UseVisualStyleBackColor = false;
            this.btn_yellow.Click += new System.EventHandler(this.btn_yellow_Click);
            // 
            // btn_blue
            // 
            this.btn_blue.BackColor = System.Drawing.Color.Blue;
            this.btn_blue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_blue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_blue.ForeColor = System.Drawing.Color.Red;
            this.btn_blue.Location = new System.Drawing.Point(37, 275);
            this.btn_blue.Name = "btn_blue";
            this.btn_blue.Size = new System.Drawing.Size(19, 18);
            this.btn_blue.TabIndex = 12;
            this.btn_blue.UseVisualStyleBackColor = false;
            this.btn_blue.Click += new System.EventHandler(this.btn_blue_Click);
            // 
            // btn_azure
            // 
            this.btn_azure.BackColor = System.Drawing.Color.Azure;
            this.btn_azure.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_azure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_azure.ForeColor = System.Drawing.Color.Red;
            this.btn_azure.Location = new System.Drawing.Point(37, 334);
            this.btn_azure.Name = "btn_azure";
            this.btn_azure.Size = new System.Drawing.Size(19, 18);
            this.btn_azure.TabIndex = 17;
            this.btn_azure.UseVisualStyleBackColor = false;
            this.btn_azure.Click += new System.EventHandler(this.btn_azure_Click);
            // 
            // btn_choco
            // 
            this.btn_choco.BackColor = System.Drawing.Color.Chocolate;
            this.btn_choco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_choco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_choco.ForeColor = System.Drawing.Color.Red;
            this.btn_choco.Location = new System.Drawing.Point(62, 334);
            this.btn_choco.Name = "btn_choco";
            this.btn_choco.Size = new System.Drawing.Size(19, 18);
            this.btn_choco.TabIndex = 16;
            this.btn_choco.UseVisualStyleBackColor = false;
            this.btn_choco.Click += new System.EventHandler(this.btn_choco_Click);
            // 
            // btn_grey
            // 
            this.btn_grey.BackColor = System.Drawing.Color.Gray;
            this.btn_grey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_grey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_grey.ForeColor = System.Drawing.Color.Red;
            this.btn_grey.Location = new System.Drawing.Point(87, 334);
            this.btn_grey.Name = "btn_grey";
            this.btn_grey.Size = new System.Drawing.Size(19, 18);
            this.btn_grey.TabIndex = 15;
            this.btn_grey.UseVisualStyleBackColor = false;
            this.btn_grey.Click += new System.EventHandler(this.btn_grey_Click);
            // 
            // btn_dimgrey
            // 
            this.btn_dimgrey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_dimgrey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_dimgrey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_dimgrey.ForeColor = System.Drawing.Color.Red;
            this.btn_dimgrey.Location = new System.Drawing.Point(12, 334);
            this.btn_dimgrey.Name = "btn_dimgrey";
            this.btn_dimgrey.Size = new System.Drawing.Size(19, 18);
            this.btn_dimgrey.TabIndex = 14;
            this.btn_dimgrey.UseVisualStyleBackColor = false;
            this.btn_dimgrey.Click += new System.EventHandler(this.btn_dimgrey_Click);
            // 
            // txt_dead
            // 
            this.txt_dead.AutoSize = true;
            this.txt_dead.Location = new System.Drawing.Point(-1, 318);
            this.txt_dead.Name = "txt_dead";
            this.txt_dead.Size = new System.Drawing.Size(136, 13);
            this.txt_dead.TabIndex = 13;
            this.txt_dead.Text = "Change Color of Dead cells";
            // 
            // Life_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 733);
            this.Controls.Add(this.btn_azure);
            this.Controls.Add(this.btn_choco);
            this.Controls.Add(this.btn_grey);
            this.Controls.Add(this.btn_dimgrey);
            this.Controls.Add(this.txt_dead);
            this.Controls.Add(this.btn_blue);
            this.Controls.Add(this.btn_yellow);
            this.Controls.Add(this.btn_purple);
            this.Controls.Add(this.btn_red);
            this.Controls.Add(this.txt_alive);
            this.Controls.Add(this.btn_onestep);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.grid);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "Life_form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game of Life";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Life_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox grid;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_onestep;
        private System.Windows.Forms.Label txt_alive;
        private System.Windows.Forms.Button btn_red;
        private System.Windows.Forms.Button btn_purple;
        private System.Windows.Forms.Button btn_yellow;
        private System.Windows.Forms.Button btn_blue;
        private System.Windows.Forms.Button btn_azure;
        private System.Windows.Forms.Button btn_choco;
        private System.Windows.Forms.Button btn_grey;
        private System.Windows.Forms.Button btn_dimgrey;
        private System.Windows.Forms.Label txt_dead;
    }
}

