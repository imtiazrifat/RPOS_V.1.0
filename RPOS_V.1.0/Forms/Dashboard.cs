using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPOS_V._1._0.Forms
{
    //public partial class Dashboard : Forms
    public partial class Dashboard : MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            var login = new Login();
            login.ShowDialog();
            login.StartPosition = FormStartPosition.CenterParent;

        }

        private void catagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aCatagory = new CategorySetup();
            aCatagory.ShowDialog();

        }
    }
}
