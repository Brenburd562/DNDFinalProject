using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DNDTHING
{
    public partial class Form1 : Form
    {
        public static int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Menu_Screen ms = new Menu_Screen();
            this.Controls.Add(ms);
        }
    }
}
