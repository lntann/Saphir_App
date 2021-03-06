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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
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

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Form3.count_form3.countn = 11;
            label1.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            button_WOC1.Hide();
            button_WOC2.Hide();
            button_WOC3.Hide();
            Form6 child1 = new Form6();
            OpenChildForm(child1, sender);
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Form3.count_form3.countn = 17;
            label1.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            button_WOC1.Hide();
            button_WOC2.Hide();
            button_WOC3.Hide();
            Form6 child1 = new Form6();
            OpenChildForm(child1, sender);
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            Form3.count_form3.countn = 22;
            label1.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            button_WOC1.Hide();
            button_WOC2.Hide();
            button_WOC3.Hide();
            Form6 child1 = new Form6();
            OpenChildForm(child1, sender);
        }
    }
}
