using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MicroOndas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textAlimento.Text = " ";
            label5.Text = " ";

            if (labelTimer.Text == "Aquecida")
            {

                labelTimer.Text = "0";
                timer1.Enabled = true;

            }

            if ((Convert.ToInt32(labelTimer.Text) + 30) > 120)
            {

                labelTimer.Text = "120";
                MessageBox.Show("Valor máximo para aquecimento é de 2 minutos");
                
            }
            else
            {

                labelTimer.Text = Convert.ToString(Convert.ToInt32(labelTimer.Text) + 30);
                timer1.Enabled = true;
                textPotencia.Text = "8";
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // A propriedade Interval do timer foi alterado para 1000 milisegundos para representar o 1 segundo de decremento

            if (Convert.ToInt32(labelTimer.Text) != 0)
            {

                labelTimer.Text = Convert.ToString(Convert.ToInt32(labelTimer.Text) - 1);

            }
            else
            {
                timer1.Enabled = false;
                labelTimer.Text = "Aquecida";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelTimer.Text = "0";
            textAlimento.CharacterCasing = CharacterCasing.Upper;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textAlimento.Text = " ";
            label5.Text = " ";

            if (textTimer.Text == "0" || textTimer.Text == string.Empty)
            {

                MessageBox.Show("O valor minimo é 1 para aquecimento.");
                return;

            }

            if (Convert.ToInt32(textPotencia.Text) < 1 || Convert.ToInt32(textPotencia.Text) > 10 || textTimer.Text == string.Empty)
            {

                MessageBox.Show("O valor para potência deve estar entre 1 e 10. Será assumido o valor 10 para padrão.");
                textPotencia.Text = "10";

            }


            if (labelTimer.Text == "Aquecida")
            {

                labelTimer.Text = "0";
                timer1.Enabled = true;

            }

            if ((Convert.ToInt32(labelTimer.Text) + Convert.ToInt32(textTimer.Text)) > 120)
            {

                labelTimer.Text = "120";
                MessageBox.Show("Valor máximo para aquecimento é de 2 minutos");

            }
            else
            {

                labelTimer.Text = Convert.ToString(Convert.ToInt32(labelTimer.Text) + Convert.ToInt32(textTimer.Text));
                timer1.Enabled = true;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelTimer.Text = "0";
            //textPotencia.Text = "0";
            textTimer.Text = "0";
            textAlimento.Text = " ";
            timer1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            } 
            else
            {
                timer1.Enabled = false;
             }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textAlimento.Text == "FRANGO")
            {
                labelTimer.Text = Convert.ToString(Convert.ToInt32(labelTimer.Text) + 50);
                textPotencia.Text = "6";
                timer1.Enabled = true;
            }
            else
            {
                label5.Text = "Alimento incompatível com o programa!";
                textAlimento.Text = " ";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textAlimento.Text == "ARROZ")
            {
                labelTimer.Text = Convert.ToString(Convert.ToInt32(labelTimer.Text) + 35);
                textPotencia.Text = "2";
                timer1.Enabled = true;
            }
            else
            {
                label5.Text = "Alimento incompatível com o programa!";
                textAlimento.Text = " ";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textAlimento.Text == "PIPOCA")
            {
                labelTimer.Text = Convert.ToString(Convert.ToInt32(labelTimer.Text) + 25);
                textPotencia.Text = "3S";
                timer1.Enabled = true;
            }
            else
            {
                label5.Text = "Alimento incompatível com o programa!";
                textAlimento.Text = " ";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textAlimento.Text == "CARNE VERMELHA")
            {
                labelTimer.Text = Convert.ToString(Convert.ToInt32(labelTimer.Text) + 90);
                textPotencia.Text = "9";
                timer1.Enabled = true;
            }
            else
            {
                label5.Text = "Alimento incompatível com o programa!";
                textAlimento.Text = " ";
            }
        }
    }
}
