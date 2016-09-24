using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Capitulo7
{
    public partial class Form1 : Form
    {
        ArrayList datos;
        public Form1()
        {
            InitializeComponent();
            datos = new ArrayList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            datos.Add(Double.Parse(maskedTextBox1.Text));
            datos.Add(Double.Parse(maskedTextBox2.Text));
            datos.Add(Double.Parse(maskedTextBox3.Text));

            Promedio(datos);
            NumeroMenor(datos);
            NumeroMayor(datos);
        }
        public void Promedio(ArrayList Arreglo)
        {
            double res = 0; 
            double promedio = 0;
            foreach (double n in Arreglo)
            {
                res = res + n;
                promedio = res / 3; 
            }
            maskedTextBox4.Text = Convert.ToString(promedio);
        }
        public void NumeroMenor(ArrayList Arreglo)
        {
            double Menor = 101.0;
            foreach (double num in Arreglo)
            {
                if (Menor > num)
                {
                    Menor = num;
                    maskedTextBox5.Text = Convert.ToString(num);
                }
                    
                }
        }
        public void NumeroMayor(ArrayList Arreglo)
        {
            double numero = 0;
            foreach (double mayor in Arreglo)
            {
                if (numero < mayor)
                    numero = mayor;
                    maskedTextBox6.Text = Convert.ToString(numero);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
            maskedTextBox5.Clear();
            maskedTextBox6.Clear();
        }
    }
}
