using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void loadTime_Tick(object sender, EventArgs e)
        {
            loadTime.Enabled = false;
            this.Hide();
            Program.mainform.Show();
        }
    }
}
