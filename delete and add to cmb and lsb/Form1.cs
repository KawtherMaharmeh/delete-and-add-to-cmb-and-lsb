using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delete_and_add_to_cmb_and_lsb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            lsbcity.Items.Add(txtlsb.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsbcity.Items.Add("maan");
        }

        private void txtshow_TextChanged(object sender, EventArgs e)
        {
            if (lsbcity .SelectedItem == null )
            txtshow.Text = lsbcity.SelectedItem.ToString();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            lsbcity.Items.Remove(lsbcity.SelectedItem);
        }

        private void btnaddc_Click(object sender, EventArgs e)
        {
            if (cmbcity.SelectedItem == null)
                cmbcity.Items.Add(txtcmb.Text);
        }

        private void btndelc_Click(object sender, EventArgs e)
        {
            cmbcity .Items.Remove(cmbcity .SelectedItem);
        }
    }
}
