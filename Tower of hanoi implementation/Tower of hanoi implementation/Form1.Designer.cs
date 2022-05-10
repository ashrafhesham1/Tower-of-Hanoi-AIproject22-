
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tower_of_hanoi_implementation
{
    public class Disc : Button
    {
        public Stick stick { get; set; }
        public int id { get; }
        public Disc(int id , Stick stick)
        {
            this.stick=stick;
            this.id = id;
        }
    }

    public class Stick : PictureBox
    {

        public Stack<int> discs { get; set; }
        public int id { get; }
        public Stick(int id)
        {
            this.id = id;
            this.discs = new Stack<int>() ;

            init_stack(0);
        }
        public Stick(int load,int id)
        {
            this.id = id;
            this.discs = new Stack<int>();

            init_stack(load);
        }

        private void init_stack(int load)
        {
            for (int i = load - 1; i >= 0; i--)
            {
                discs.Push(i);
            }
        }

    }
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.solve_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stick1 = new Stick(3,0); //all discs initially on the first stick
            this.stick2 = new Stick(1);
            this.stick3 = new Stick(2);
            this.disc1 = new Disc(0, this.stick1);
            this.disc2 = new Disc(1, this.stick1);
            this.disc3 = new Disc(2, this.stick1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stick1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stick2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stick3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Sienna;
            this.pictureBox1.Location = new System.Drawing.Point(83, 374);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 30);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Sienna;
            this.pictureBox4.Location = new System.Drawing.Point(428, 374);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(286, 30);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Sienna;
            this.pictureBox6.Location = new System.Drawing.Point(779, 374);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(286, 30);
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // solve_btn
            // 
            this.solve_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.solve_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solve_btn.ForeColor = System.Drawing.Color.Chocolate;
            this.solve_btn.Location = new System.Drawing.Point(498, 444);
            this.solve_btn.Name = "solve_btn";
            this.solve_btn.Size = new System.Drawing.Size(139, 44);
            this.solve_btn.TabIndex = 9;
            this.solve_btn.Text = "Solve";
            this.solve_btn.UseVisualStyleBackColor = true;
            this.solve_btn.Click += new System.EventHandler(this.solve_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(415, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 72);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tower of hanoi";
            // 
            // stick1
            // 
            this.stick1.BackColor = System.Drawing.Color.Sienna;
            this.stick1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stick1.Location = new System.Drawing.Point(205, 113);
            this.stick1.Name = "stick1";
            this.stick1.Size = new System.Drawing.Size(29, 275);
            this.stick1.TabIndex = 1;
            this.stick1.TabStop = false;
            this.stick1.Click += new System.EventHandler(this.stick_Click);
            // 
            // stick2
            // 
            this.stick2.BackColor = System.Drawing.Color.Sienna;
            this.stick2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stick2.Location = new System.Drawing.Point(550, 113);
            this.stick2.Name = "stick2";
            this.stick2.Size = new System.Drawing.Size(29, 275);
            this.stick2.TabIndex = 3;
            this.stick2.TabStop = false;
            this.stick2.Click += new System.EventHandler(this.stick_Click);
            // 
            // stick3
            // 
            this.stick3.BackColor = System.Drawing.Color.Sienna;
            this.stick3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stick3.Location = new System.Drawing.Point(901, 113);
            this.stick3.Name = "stick3";
            this.stick3.Size = new System.Drawing.Size(29, 275);
            this.stick3.TabIndex = 5;
            this.stick3.TabStop = false;
            this.stick3.Click += new System.EventHandler(this.stick_Click);
            // 
            // disc1
            // 
            this.disc1.BackColor = System.Drawing.Color.Teal;
            this.disc1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disc1.FlatAppearance.BorderSize = 0;
            this.disc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disc1.Location = new System.Drawing.Point(161, 227);
            this.disc1.Name = "disc1";
            this.disc1.Size = new System.Drawing.Size(117, 44);
            this.disc1.stick = this.stick1;
            this.disc1.TabIndex = 8;
            this.disc1.UseVisualStyleBackColor = false;
            this.disc1.Click += new System.EventHandler(this.disc_click);
            // 
            // disc2
            // 
            this.disc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.disc2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disc2.FlatAppearance.BorderSize = 0;
            this.disc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disc2.Location = new System.Drawing.Point(145, 277);
            this.disc2.Name = "disc2";
            this.disc2.Size = new System.Drawing.Size(162, 44);
            this.disc2.stick = this.stick1;
            this.disc2.TabIndex = 7;
            this.disc2.UseVisualStyleBackColor = false;
            this.disc2.Click += new System.EventHandler(this.disc_click);
            // 
            // disc3
            // 
            this.disc3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.disc3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disc3.FlatAppearance.BorderSize = 0;
            this.disc3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disc3.Location = new System.Drawing.Point(117, 327);
            this.disc3.Name = "disc3";
            this.disc3.Size = new System.Drawing.Size(230, 44);
            this.disc3.stick = this.stick1;
            this.disc3.TabIndex = 6;
            this.disc3.UseVisualStyleBackColor = false;
            this.disc3.Click += new System.EventHandler(this.disc_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1141, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solve_btn);
            this.Controls.Add(this.disc1);
            this.Controls.Add(this.disc2);
            this.Controls.Add(this.disc3);
            this.Controls.Add(this.stick3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.stick2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.stick1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Tower of Hanoi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stick1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stick2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stick3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Stick stick1;
        private Stick stick2;
        private Stick stick3;
        private Disc disc3;
        private Disc disc2;
        private Disc disc1;
        private System.Windows.Forms.Button solve_btn;
        private System.Windows.Forms.Label label1;
    }
}

