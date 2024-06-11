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
        List<Animal> animals = new List<Animal>();
        Animal animal = new Animal();

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
            animal.raza=textBox4.Text;
            animal.edad= Convert.ToDouble(textBox5.Text);
            animal.id= textBox6.Text;
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            animals.Add(animal);
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Debes especifiar un id de animal");
            }
            else
            {
                animals.RemoveAll(idAnimal => idAnimal.id == textBox4.Text);
                Console.WriteLine("-------------------------------- Animalito eliminado---------------------------------------");

                foreach (var animal in animals)
                {

                    Console.WriteLine(animal.raza);
                }
                Console.WriteLine("--------------------------------Fin de impresión de animalitos---------------------------------------");

                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }
        }
    }
}
