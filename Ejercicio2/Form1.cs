using System;
using System.Collections;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hashtable semana = new Hashtable();

            semana.Add("1", "Lunes");
            semana.Add("2", "Martes");
            semana.Add("3", "Miercoles");
            semana.Add("4", "Jueves");
            semana.Add("5", "Viernes");
            semana.Add("6", "Sabado");
            semana.Add("7", "Domingo");

            MessageBox.Show(semana["5"].ToString());
            semana.Remove("3");
            foreach (DictionaryEntry dias in semana)
            {
                MessageBox.Show(dias.Key + "   -   " + dias.Value);
            }
        }
    }
}
