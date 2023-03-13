using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir_Cafe
{
    public partial class Kasir_Cafe : Form
    {
        public Kasir_Cafe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bantuan = Application.StartupPath + @"\Bantu Cafe.chm";
            Help.ShowHelp(this, bantuan, HelpNavigator.TableOfContents);
        }
    }
}
