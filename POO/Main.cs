using POO.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona2 = new Persona("116850308","Silvia",26);
            textBox1.Text=persona2.GetNombre();
            textBox2.Text=persona2.GetCedula();
            textBox3.Text=persona2.GetEdad().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.SetNombre(textBox1.Text);
            persona.SetCedula(textBox2.Text);
            persona.SetEdad(Convert.ToDouble(textBox3.Text));
            MessageBox.Show(persona.getAll());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            animal.raza=textBox4.Text;
            animal.edad= Convert.ToDouble(textBox5.Text);
            animal.id= textBox6.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
