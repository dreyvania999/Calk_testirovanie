using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calk_6LR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double stor1 = 0, stor2 = 0, stor3 = 0;
            int colch=0;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox4.Visible = false;
            while (colch<3)
            {
                if (textBox1.Text == ""|| textBox2.Text == ""|| textBox3.Text == "")
                {
                    textBox4.Visible = true;
                    textBox4.Text = "Не все поля заполнены";
                    break;
                }
                else
                {
                    
                    if (Convert.ToDouble(textBox1.Text) < 1)
                    {
                        textBox5.Text = "Проверьте корректность ввода значений";
                        textBox5.Visible = true;
                    }
                    else
                    {
                        stor1 = Convert.ToDouble(textBox1.Text);
                        colch++;
                    }
                    if (Convert.ToDouble(textBox2.Text) < 1)
                    {
                        textBox6.Text = "Проверьте корректность ввода значений";
                        textBox6.Visible = true;
                    }
                    else
                    {
                        stor2 = Convert.ToDouble(textBox2.Text);
                        colch++;
                    }
                    if (Convert.ToDouble(textBox3.Text) < 1)
                    {
                        textBox7.Text = "Проверьте корректность ввода значений";
                        textBox7.Visible = true;
                    }
                    else
                    {
                        stor3 = Convert.ToDouble(textBox3.Text);
                        colch++;
                    }
                    textBox4.Visible = true;
                    if ((stor1 + stor2 > stor3) && (stor1 + stor3 > stor2) && (stor2 + stor3 > stor1))
                    {
                        if ((stor1 == stor2) || (stor1 == stor3) || (stor2 == stor3))
                        {
                            if ((stor1 == stor2) && (stor1 == stor3) && (stor2 == stor3))
                            {
                                textBox4.Text = "Это равносторонний треугольник";
                            }
                            else
                            {
                                textBox4.Text = "Это равнобедренный треугольник";
                            }
                        }
                        else
                        {
                            textBox4.Text = "Это неравносторонний треугольник";
                        }
                    }
                    else
                    {
                        textBox4.Text = "Подобный треугольник не может существовать на плоскости";
                    }
                }
            }

            

        }


    }
}
