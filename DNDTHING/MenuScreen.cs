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
    public partial class Menu_Screen : UserControl
    {
        public Menu_Screen()
        {
            InitializeComponent();
        }

        private void Menu_Screen_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ms = this.FindForm();
            ms.Controls.Remove(this);

            NewCharacterCreation ncc = new NewCharacterCreation();
            ms.Controls.Add(ncc);
            ncc.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ms = this.FindForm();
            ms.Controls.Remove(this);

            CharacterSearch cs = new CharacterSearch();
            ms.Controls.Add(cs);
            cs.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ms = this.FindForm();
            ms.Controls.Remove(this);

            DiceRoll dr = new DiceRoll();
            ms.Controls.Add(dr);
            dr.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
