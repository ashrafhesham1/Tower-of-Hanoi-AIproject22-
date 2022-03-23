using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tower_of_hanoi_implementation
{
   
    public partial class Form1 : Form
    {
        Disc active_disc ;
        
        public Form1()
        {
            InitializeComponent();

            active_disc = null;
        }



        private void disc_click(object sender, EventArgs e)
        {
            active_disc = sender as Disc;
            toggle_sticks_hover();

        }

        private void stick_Click(object sender, EventArgs e)
        {
            Stick stick = sender as Stick;

            //check if the movement is legal
            if (this.active_disc == null)
                return;
            if (this.active_disc.stick.id == stick.id)
                return;
            if (this.active_disc.id > stick.top)
                return;
            if (this.active_disc.id != this.active_disc.stick.top)
                return;

            //calculat disc's new position
            Point p = new Point();

            p.X = stick.Location.X - this.active_disc.Width/2 + stick.Width/2;
            p.Y = 265 - stick.load*44; //initial possition + (n.sticks * disc height)

            //update UI
            this.active_disc.Location = p;

            //Update game's internal state
            stick.load++;
            stick.top = this.active_disc.id;

            this.active_disc.stick.load--;
            this.active_disc.stick.top = this.active_disc.stick.load>0 ? ++this.active_disc.stick.top : 4 ;
            this.active_disc.stick = stick;

            this.active_disc = null;


            toggle_sticks_hover();

            //check winning
            if (this.stick3.load == 3 || this.stick2.load == 3)
                MessageBox.Show("You Won!!");

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
