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
    public partial class Form3 : Form
    {
        int check1 = 0;
        int check2 = 0;
        int check3 = 0;
        int check4 = 0;
        int check5 = 0;
        int check6 = 0;
        int check7 = 0;
        int check8 = 0;
        int check9 = 0;
        int check10 = 0;
        int check11 = 0;
        int check12 = 0;
        int check13 = 0;
        int check14 = 0;
        int check15 = 0;
        int check16 = 0;
        int check17 = 0;
        int check18 = 0;
        int check19 = 0;
        int check20 = 0;
        int check21 = 0;
        int check22 = 0;
        int check23 = 0;
        int check24 = 0;
        int check25 = 0;
        int check26 = 0;
        int check27 = 0;
        int check28 = 0;
        int check29 = 0;
        int check30 = 0;

        int count = 0;
        public Form3()
        {
            InitializeComponent();
            activeForm = this;
        }
        public class count_form3
        {
            static public int countn;
        }
        public int check_form()
        {
            return check1;
        }
        public int check_form1()
        {
            return check2;
        }

        public int check_form2()
        {
            return check3;
        }
        public int check_form4()
        {
            return check4;
        }
        public int check_form5()
        {
            return check5;
        }
        public int check_form6()
        {
            return check6;
        }
        public int check_form7()
        {
            return check7;
        }
        public int check_form8()
        {
            return check8;
        }
        public int check_form9()
        {
            return check9;
        }
        public int check_form10()
        {
            return check10;
        }
        public int check_form11()
        {
            return check11;
        }
        public int check_form12()
        {
            return check12;
        }
        public int check_form13()
        {
            return check13;
        }
        public int check_form14()
        {
            return check14;
        }
        public int check_form15()
        {
            return check15;
        }
        public int check_form16()
        {
            return check16;
        }
        public int check_form17()
        {
            return check17;
        }
        public int check_form18()
        {
            return check18;
        }
        public int check_form19()
        {
            return check19;
        }
        public int check_form20()
        {
            return check20;
        }

        public int check_form21()
        {
            return check21;
        }
        public int check_form22()
        {
            return check22;
        }
        public int check_form23()
        {
            return check23;
        }
        public int check_form24()
        {
            return check24;
        }
        public int check_form25()
        {
            return check25;
        }
        public int check_form26()
        {
            return check26;
        }
        public int check_form27()
        {
            return check27;
        }
        public int check_form28()
        {
            return check28;
        }
        public int check_form29()
        {
            return check29;
        }
        public int check_form30()
        {
            return check30;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Hide();
            checkBox3.Hide();
            count += 3;
            check1++;
            if(check1%2==0)
            {
                count -= 3;
                checkBox2.Show();
                checkBox3.Show();
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Hide();
            checkBox3.Hide();
            count += 2;
            check2++;
            if (check2 % 2 == 0)
            {
                count -= 2;
                checkBox1.Show();
                checkBox3.Show();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Hide();
            checkBox2.Hide();
            count += 1;
            check3++;
            if(check3%2==0)
            {
                checkBox1.Show();
                checkBox2.Show();
                count -= 1;
            }
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            checkBox28.Hide();
            checkBox29.Hide();
            count += 3;
            check30++;
            if(check30%2==0)
            {
                checkBox28.Show();
                checkBox29.Show();
                count -= 3;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.Hide();
            checkBox5.Hide();
            count += 1;
            check6++;
            if (check6 % 2 == 0)
            {
                checkBox4.Show();
                checkBox5.Show();
                count -= 1;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            checkBox7.Hide();
            checkBox8.Hide();
            count += 3;
            check9++;
            if (check9 % 2 == 0)
            {
                checkBox7.Show();
                checkBox8.Show();
                count -= 3;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            checkBox10.Hide();
            checkBox11.Hide();
            count += 3;
            check12++;
            if (check12 % 2 == 0)
            {
                checkBox10.Show();
                checkBox11.Show();
                count -= 3;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //count += 2;
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            checkBox17.Hide();
            checkBox16.Hide();
            count += 1;
            check18++;
            if (check18 % 2 == 0)
            {
                checkBox17.Show();
                checkBox16.Show();
                count -= 1;
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            checkBox20.Hide();
            checkBox19.Hide();
            count += 3;
            check21++;
            if (check21 % 2 == 0)
            {
                checkBox20.Show();
                checkBox19.Show();
                count -= 3;
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            checkBox22.Hide();
            checkBox23.Hide();
            count += 3;
            check24++;
            if (check24 % 2 == 0)
            {
                checkBox22.Show();
                checkBox23.Show();
                count -= 3;
            }
           
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            checkBox26.Hide();
            checkBox25.Hide();
            count += 1;
            check27++;
            if (check27 % 2 == 0)
            {
                checkBox26.Show();
                checkBox5.Show();
                count -= 1;
            }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            checkBox28.Hide();
            checkBox30.Hide();
            count += 2;
            check29++;
            if(check29%2==0)
            {
                checkBox28.Show();
                checkBox30.Show();
                count -= 2;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox6.Hide();
            checkBox4.Hide();
            count += 2;
            check5++;
            if (check5 % 2 == 0)
            {
                checkBox6.Show();
                checkBox4.Show();
                count -= 2;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            checkBox7.Hide();
            checkBox9.Hide();
            count += 2;
            check8++;
            if (check8 % 2 == 0)
            {
                checkBox7.Show();
                checkBox9.Show();
                count -= 2;
            }

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            checkBox10.Hide();
            checkBox12.Hide();
            count += 2;
            check11++;
            if (check11 % 2 == 0)
            {
                checkBox10.Show();
                checkBox12.Show();
                count -= 2;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            checkBox13.Hide();
            checkBox15.Hide();
            count += 3;
            check14++;
            if (check14 % 2 == 0)
            {
                checkBox13.Show();
                checkBox15.Show();
                count -= 3;
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            checkBox16.Hide();
            checkBox18.Hide();
            count += 2;
            check17++;
            if (check17 % 2 == 0)
            {
                checkBox16.Show();
                checkBox18.Show();
                count -= 2;
            }
           
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            checkBox19.Hide();
            checkBox21.Hide();
            count += 2;
            check20++;
            if (check20 % 2 == 0)
            {
                checkBox19.Show();
                checkBox21.Show();
                count -= 2;
            }
            
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            checkBox22.Hide();
            checkBox24.Hide();
            count += 2;
            check23++;
            if (check23 % 2 == 0)
            {
                checkBox22.Show();
                checkBox24.Show();
                count -= 2;
            }
          
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            checkBox25.Hide();
            checkBox27.Hide();
            count += 2;
            check26++;
            if (check26 % 2 == 0)
            {
                checkBox25.Show();
                checkBox27.Show();
                count -= 2;
            }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            checkBox29.Hide();
            checkBox30.Hide();
            count += 1;
            check28++;
            if (check28 % 2 == 0)
            {
                checkBox29.Show();
                checkBox30.Show();
                count -= 1;
            }
           
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.Hide();
            checkBox6.Hide();
            count += 3;
            check4++;
            if (check4 % 2 == 0)
            {
                checkBox5.Show();
                checkBox6.Show();
                count -= 3;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            checkBox8.Hide();
            checkBox9.Hide();
            count += 1;
            check7++;
            if (check7 % 2 == 0)
            {
                checkBox8.Show();
                checkBox9.Show();
                count -= 1;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            checkBox11.Hide();
            checkBox12.Hide();
            count += 1;
            check10++;
            if (check10 % 2 == 0)
            {
                checkBox11.Show();
                checkBox12.Show();
                count -= 1;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            checkBox14.Hide();
            checkBox15.Hide();
            count += 1;
            check13++;
            if (check13 % 2 == 0)
            {
                checkBox14.Show();
                checkBox15.Show();
                count -= 1;
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            checkBox17.Hide();
            checkBox18.Hide();
            count += 3;
            check16++;
            if (check16 % 2 == 0)
            {
                checkBox17.Show();
                checkBox18.Show();
                count -= 3;
            }
            
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            checkBox20.Hide();
            checkBox21.Hide();
            count += 1;
            check19++;
            if (check19 % 2 == 0)
            {
                checkBox20.Show();
                checkBox21.Show();
                count -= 1;
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            checkBox23.Hide();
            checkBox24.Hide();
            count += 1;
            check22++;
            if (check22 % 2 == 0)
            {
                checkBox23.Show();
                checkBox24.Show();
                count -= 1;
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            checkBox26.Hide();
            checkBox27.Hide();
            count += 3;
            check25++;
            if (check25 % 2 == 0)
            {
                checkBox26.Show();
                checkBox27.Show();
                count -= 3;
            }
           
        }
        private Form activeForm;
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
            childForm.BringToFront();
            childForm.Show();
            //lblTitle.Text = childForm.Text;
        }
       

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            // this.Close();
            count_form3.countn = count;
            Form4 child = new Form4();
            //MessageBox.Show(count.ToString());
            OpenChildForm(child, sender);
           

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            checkBox14.Hide();
            checkBox13.Hide();
            count += 2;
            check15++;
            if (check15 % 2 == 0)
            {
                checkBox14.Show();
                checkBox13.Show();
                count -= 2;
            }
        }
    }
}
