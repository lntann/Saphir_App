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
    public partial class Form6 : Form
    {
        public Form6()
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
            Form7 child1 = new Form7();
            label1.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            button_WOC1.Hide();
            button_WOC2.Hide();
            button_WOC3.Hide();
            
            OpenChildForm(child1, sender);
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Form8 child1 = new Form8();
            label1.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            button_WOC1.Hide();
            button_WOC2.Hide();
            button_WOC3.Hide();
            OpenChildForm(child1, sender);
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            Form9 child1 = new Form9();
            label1.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            button_WOC1.Hide();
            button_WOC2.Hide();
            button_WOC3.Hide();
            OpenChildForm(child1, sender);
        }
    }
}
