using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_SystemIO
{
    public partial class Form1 : Form
    {
        DataBase data;
        List<Customer> customerList;

        public Form1()
        {
            InitializeComponent();

            data = new DataBase();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            customerList = data.customerList(100);
            lstCustormer.DataSource = customerList;
        }

        private void lstCustormer_DoubleClick(object sender, EventArgs e)
        {
            Customer ClickCustormer = lstCustormer.SelectedItem as Customer;

            comboIName.Text = ClickCustormer.name;
            comboSurname.Text = ClickCustormer.surName;
            comboEmail.Text = ClickCustormer.email;
            comboCountry.Text = ClickCustormer.country;
            comboCompany.Text = ClickCustormer.company;

        }
    }
}
