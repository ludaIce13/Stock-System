using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_System
{
    public partial class StockSystem : Form
    {
        public StockSystem()
        {
            InitializeComponent();
        }

       

        private void StockSystem_Load(object sender, EventArgs e)
        {

        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products pro = new Products();
            pro.MdiParent= this;
            pro.Show();
        }

        private void StockSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
