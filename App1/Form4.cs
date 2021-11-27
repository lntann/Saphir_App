using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Form4 : Form
    {
        public void OpenChildForm(Form childForm, object btnSender)
        {
            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public Form4()
        {
            InitializeComponent();
            if (Form3.count_form3.countn >= 10 && Form3.count_form3.countn <= 15)
            {
                label1.Text += " Dry Skin";
            }

            if (Form3.count_form3.countn >= 16 && Form3.count_form3.countn <= 20)
            {
                label1.Text += " Normal Skin";
            }

            if (Form3.count_form3.countn >= 21 && Form3.count_form3.countn <= 32)
            {
                label1.Text += " Oil Skin";
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Form6 child1 = new Form6();
            OpenChildForm(child1, sender);
        }
    }
}
