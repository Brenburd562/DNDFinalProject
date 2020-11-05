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
    public partial class CharacterPrintOut : UserControl
    {
        public CharacterPrintOut()
        {
            InitializeComponent();
        }

        private void CharacterPrintOut_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            Form cpo = this.FindForm();
            cpo.Controls.Remove(this);

            Menu_Screen ms = new Menu_Screen();
            cpo.Controls.Add(ms);
            ms.Focus();
        }
    }
}
