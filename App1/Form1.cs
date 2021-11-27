using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace App1
{
    public partial class Form1 : Form
    {
        private Form2 child;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
  
        public void OpenChildForm(Form childForm, object btnSender)
        {
           // if (activeForm != null)
           // activeForm.Close();
           // ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
           // childForm.BringToFront();
            childForm.Show();
            //lblTitle.Text = childForm.Text;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            pictureBox3.Hide();
            button_WOC1.Hide();
            label2.Hide();
            pictureBox1.Hide();
            child = new Form2();
            OpenChildForm(child, sender);
        }
    }
    }
