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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }
        public void OpenChildForm(Form childForm, object btnSender)
        {
           
            //  if (activeForm != null)
            //     activeForm.Close();
            // ActivateButton(btnSender);
            // activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            // childForm.BringToFront();
            childForm.Show();
            //lblTitle.Text = childForm.Text;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            // Form1 a = new Form1();
            Form3 child = new Form3();
            label1.Hide();
            label2.Hide();
            button_WOC1.Hide();
            button_WOC2.Hide();
            OpenChildForm(child, sender);

            // a.Show();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Form5 child1 = new Form5();
            label1.Hide();
            label2.Hide();
            button_WOC1.Hide();
            button_WOC2.Hide();
            OpenChildForm(child1, sender);
        }
    }
}
