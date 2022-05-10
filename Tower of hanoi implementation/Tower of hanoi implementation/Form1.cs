using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Tower_of_hanoi_implementation
{
   
    public partial class Form1 : Form
    {
        Disc active_disc ;
        Disc[] all_discs ;
        Stick[] all_stics;
        
        public Form1()
        {
            InitializeComponent();

            active_disc = null;
            all_discs = new Disc[3] {disc1,disc2,disc3};
            all_stics = new Stick[3] { stick1,stick2,stick3 };

        }

        private void disc_click(object sender, EventArgs e)
        {
            this.active_disc = sender as Disc;
            toggle_sticks_hover();

        }

        private void stick_Click(object sender, EventArgs e)
        {
            Stick stick = sender as Stick;

            perform_move(stick);
            
        }

        private void solve_btn_Click(object sender, EventArgs e)
        {
            solve(3, 1, 2, 3);
        }

        private void perform_move(Stick stick)
        {
            // check if the move is valid
            if (this.active_disc == null)
                return;
            if (this.active_disc.stick.id == stick.id)
                return;
            if (stick.discs.Count != 0 && this.active_disc.id > stick.discs.Peek())
                return;
            if (this.active_disc.id != this.active_disc.stick.discs.Peek())
                return;

            update_ui(stick,this.active_disc);

            update_internal_state(stick);


            toggle_sticks_hover();

            check_winner();
        }

        private void update_ui( Stick stick ,Disc disc )
        {
            Point p = new Point();

            //calculat disc's new position
            p.X = stick.Location.X - disc.Width / 2 + stick.Width / 2;
            p.Y = 265 - stick.discs.Count * 44; //initial possition + (n.sticks * disc height)

            //Update ui
            disc.Location = p;
        }

        private void update_internal_state (Stick stick)
        {
            // removing the disc from the old stick
            this.active_disc.stick.discs.Pop();

            // adding the disk to the new stick
            stick.discs.Push(this.active_disc.id); 
            this.active_disc.stick = stick;

            this.active_disc = null;
        }

        private void check_winner()
        {
            if (this.stick3.discs.Count == 3)
                MessageBox.Show("You Won!!");
        }

        private void solve(int n, int from, int aux, int to)
        {
            if (n == 1)
            {
                perform_auto_move(n , to);
                return;
            }
            else
            {
                solve(n - 1 , from, to, aux);
                perform_auto_move(n , to);
                solve(n - 1, aux, from, to);
            }
        }

        private void perform_auto_move(int disc_position , int stick_position)
        {
            this.active_disc = all_discs[disc_position - 1];
            perform_move(all_stics[stick_position - 1]);
            System.Threading.Thread.Sleep(500);
        }

        private void toggle_sticks_hover()
        {
            this.stick1.Cursor = this.stick1.Cursor == Cursors.Hand ? Cursors.Default : Cursors.Hand;
            this.stick2.Cursor = this.stick2.Cursor == Cursors.Hand ? Cursors.Default : Cursors.Hand;
            this.stick3.Cursor = this.stick3.Cursor == Cursors.Hand ? Cursors.Default : Cursors.Hand;

        }


    }


    internal struct NewStruct
    {
        public int Item1;
        public int Item2;

        public NewStruct(int item1, int item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public override bool Equals(object obj)
        {
            return obj is NewStruct other &&
                   Item1 == other.Item1 &&
                   Item2 == other.Item2;
        }

        public override int GetHashCode()
        {
            int hashCode = -1030903623;
            hashCode = hashCode * -1521134295 + Item1.GetHashCode();
            hashCode = hashCode * -1521134295 + Item2.GetHashCode();
            return hashCode;
        }

        public void Deconstruct(out int item1, out int item2)
        {
            item1 = Item1;
            item2 = Item2;
        }

        public static implicit operator (int, int)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((int, int) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }
}
