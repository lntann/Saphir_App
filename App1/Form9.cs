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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            if (Form3.count_form3.countn >= 10 && Form3.count_form3.countn <= 15)
            {
                label1.Text = "Centaphil Gentle Skin Cleanser";
                label2.Text = "Bioderma Sensebio";
                label3.Text = "Estee Lauder Serum";
                label4.Text = "Vichy Liftactiv Cream";
                label5.Text = "Toner Lotion Toniqe";
            }
            if (Form3.count_form3.countn >= 16 && Form3.count_form3.countn <= 20)
            {
                label1.Text = "Cerave Skin Cleanser";
                label2.Text = "L'oreal Micella Water";
                label3.Text = "Estee Lauder Serum";
                label4.Text = "Vichy Liftactiv Cream";
                label5.Text = "Toner Simple";
            }
            label1.Text = "Cerave Cleanser";
            label2.Text = "Bioderma No Sebum";
            label3.Text = "Estee Lauder Serum";
            label4.Text = "Vichy Liftactiv Cream";
            label5.Text = "Toner Derladie";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
