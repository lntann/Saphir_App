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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            if (Form3.count_form3.countn >= 10 && Form3.count_form3.countn <= 15)
            {
                label1.Text = "Centaphil Gentle Skin Cleanser";
                label2.Text = "Bioderma Sensebio";
                label3.Text = "Madagasca Centela Serum";
                label4.Text = "Innisfree Blossom Cream";
                label5.Text = "Toner Lotion Toniqe";
            }

            if (Form3.count_form3.countn >= 16 && Form3.count_form3.countn <= 20)
            {
                label1.Text = "Cerave Skin Cleanser";
                label2.Text = "L'oreal Micella Water";
                label3.Text = "Some By Mi AHA";
                label4.Text = "La Roche Posay B5";
                label5.Text = "Toner Simple";
            }

            if (Form3.count_form3.countn >= 21 && Form3.count_form3.countn <= 32)
            {

                label1.Text = "Cerave Cleanser";
                label2.Text = "Bioderma No Sebum";
                label3.Text = "Eucerin Pro Acne Solution Super";
                label4.Text = "Dramatically Different™ Moisturizing Gel";
                label5.Text = "Toner Derladie";

            }
        }

        private void label1_Click(object sender, EventArgs e)
        { 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
