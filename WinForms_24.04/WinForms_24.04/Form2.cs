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
    public partial class Form2 : Form
    {
        Form1 form1 = null;
        bool is_redact = false;
        int i;
        public Form2(Form1 form)
        {
            InitializeComponent();
            this.form1 = form;
        }
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form, Tovar obj)
        {
            InitializeComponent();
            this.form1 = form;
            Tovar tovar = obj as Tovar;
            txbName.Text = tovar.Name;
            txbStrana.Text = tovar.Strana;
            txbZena.Text = tovar.Zena.ToString();
            i = form1.tovars.IndexOf(tovar);
            is_redact = true;
        }

        private void btnOtmena_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {                     
            if (!is_redact)
            {
                Tovar tovar = new Tovar();
                form1.tovars.Add(tovar);
                i = form1.tovars.Count - 1;
            }
            form1.tovars[i].Name = txbName.Text;
            form1.tovars[i].Strana = txbStrana.Text;
            form1.tovars[i].Zena = int.Parse(txbZena.Text);

            DialogResult = DialogResult.OK;
        }
    }
}
