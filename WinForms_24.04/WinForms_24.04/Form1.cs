using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_24._04
{
    public partial class Form1 : Form
    {
        public List<Tovar> tovars { get; set; }
        public Form1()
        {
            InitializeComponent();
            tovars = new List<Tovar>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                listBox.DataSource = null;
                listBox.DataSource = tovars;
            }           
        }

        private void btnRedact_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this, listBox.SelectedItem as Tovar);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                UpDateList();               
            }
        }

        private void UpDateList()
        {
            listBox.DataSource = null;
            listBox.DataSource = tovars;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tovars.Remove(listBox.SelectedItem as Tovar);
            UpDateList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tovars.Clear();
            listBox.DataSource = null;
        }
    }
}
