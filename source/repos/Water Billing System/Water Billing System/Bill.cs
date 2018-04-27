using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water_Billing_System
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'water_Billing_SystemDataSet2.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.water_Billing_SystemDataSet2.Bill);

        }
    }
}
