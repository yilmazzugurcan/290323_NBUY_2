using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _290323_NBUY_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.Columns.Add("Marka", 100);
            listView1.Columns.Add("Model", 100);
        }

        private void cmbmodel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog Renk = new ColorDialog();
            Renk.ShowDialog();
            this.BackColor = Renk.Color;
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenMarka = cmbMarka.SelectedItem.ToString();
            

            if (secilenMarka == "VOLKSWAGEN")
            {
                cmbmodel.Items.Add("POLO");
                cmbmodel.Items.Add("GOLF");
            }
            else if (secilenMarka == "OPEL")
            {
                cmbmodel.Items.Add("INSIGNIA");
                cmbmodel.Items.Add("ASTRA");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            
            string selectedMarka = cmbMarka.SelectedItem.ToString();
            string selectedModel = cmbmodel.SelectedItem.ToString();
            ListViewItem item = new ListViewItem(new[] { selectedMarka, selectedModel });
            listView1.Items.Add(item);
        }
    }
}
