using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNDTHING
{
    public partial class DiceRoll : UserControl
    {
        public DiceRoll()
        {
            InitializeComponent();

            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            Form dr = this.FindForm();
            dr.Controls.Remove(this);

            Menu_Screen ms = new Menu_Screen();
            dr.Controls.Add(ms);
            ms.Focus();
        }

        private void RollButt_Click(object sender, EventArgs e)
        {
            {
                Random rd = new Random();

                int rand_num = rd.Next(1, 21);

                if (rand_num == 20)
                {

                    DiceBox.BackgroundImage = Properties.Resources.Nat_20;

                }
                else if (rand_num == 19)
                {
                    DiceBox.BackgroundImage = Properties.Resources._19;

                }
                else if (rand_num == 18)
                {

                    DiceBox.BackgroundImage = Properties.Resources._18;
                }
                else if (rand_num == 17)
                {

                    DiceBox.BackgroundImage = Properties.Resources._17;
                }
                else if (rand_num == 16)
                {

                    DiceBox.BackgroundImage = Properties.Resources._16;
                }
                else if (rand_num == 15)
                {

                    DiceBox.BackgroundImage = Properties.Resources._15;
                }
                else if (rand_num == 14)
                {

                    DiceBox.BackgroundImage = Properties.Resources._14;
                }
                else if (rand_num == 13)
                {

                    DiceBox.BackgroundImage = Properties.Resources._13;
                }
                else if (rand_num == 12)
                {

                    DiceBox.BackgroundImage = Properties.Resources._12;
                }
                else if (rand_num == 11)
                {

                    DiceBox.BackgroundImage = Properties.Resources._11;
                }
                else if (rand_num == 10)
                {

                    DiceBox.BackgroundImage = Properties.Resources._10;

                }
                else if (rand_num == 9)
                {

                    DiceBox.BackgroundImage = Properties.Resources._9;
                }
                else if (rand_num == 8)
                {

                    DiceBox.BackgroundImage = Properties.Resources._8;
                }
                else if (rand_num == 7)
                {

                    DiceBox.BackgroundImage = Properties.Resources._7;
                }
                else if (rand_num == 6)
                {

                    DiceBox.BackgroundImage = Properties.Resources._6;
                }
                else if (rand_num == 5)
                {

                    DiceBox.BackgroundImage = Properties.Resources._5;
                }
                else if (rand_num == 4)
                {

                    DiceBox.BackgroundImage = Properties.Resources._4;
                }
                else if (rand_num == 3)
                {

                    DiceBox.BackgroundImage = Properties.Resources._2;

                }
                else if (rand_num == 2)
                {

                    DiceBox.BackgroundImage = Properties.Resources._2;
                }
                else if (rand_num == 1)
                {

                    DiceBox.BackgroundImage = Properties.Resources.Nat_1;
                }
            }
        }
    }
}
