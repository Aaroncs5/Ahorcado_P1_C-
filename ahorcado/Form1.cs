using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ahorcado
{
    public partial class Form1 : Form
    {
        char[] PalabrasAdivinadas; int Oportunidades;
        char[] PalabrasSeleccionada;
        char[] Alfabeto;
        string[] PALABRA;

        public void IniciarJuego()
        {
            
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FLP1.Controls.Clear();
            FLP1.Enabled = true;
            pictureBox1.Image = null;
            LBLMensaje.Visible = false;
            Oportunidades = 0;
            PALABRA = new string[] { "Hola", "Universidad", "Counter", "Telefono", "Celular", "Mouse", "Pachon", "Mesa", "cuaderno", "Tiktok", "wismichu", "Computadora", "Programación", "Calculadora", "Hoja", "Cocodrilo" };
            Alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".ToCharArray();

            Random nR = new Random();
            int IndiceDeLaPalabraSeleccionada = nR.Next(0, PALABRA.Length);
            PalabrasSeleccionada = PALABRA[IndiceDeLaPalabraSeleccionada].ToUpper().ToCharArray();
            PalabrasAdivinadas = PalabrasSeleccionada;

            foreach (Char LetrasAlfabeto in Alfabeto)
            {
                Button BTNLetra = new Button();
                BTNLetra.Tag = "";
                BTNLetra.Text = LetrasAlfabeto.ToString();
                BTNLetra.Width = 60;
                BTNLetra.Height = 40;
                BTNLetra.ForeColor = Color.White;
                BTNLetra.Font = new Font(BTNLetra.Font.Name, 15, FontStyle.Italic);
                BTNLetra.BackColor = Color.Black;
                BTNLetra.Name = LetrasAlfabeto.ToString();
                FLP1.Controls.Add(BTNLetra);
            }
            FLP2.Controls.Clear();

            for(int INValorDeLetra =0;INValorDeLetra < PalabrasSeleccionada.Length; INValorDeLetra++)
            {
                TextBox ColocaRP4 = new TextBox();
                ColocaRP4.Tag = PalabrasSeleccionada[INValorDeLetra].ToString();
                ColocaRP4.Width = 50;
                ColocaRP4.Height = 80;
                ColocaRP4.ForeColor = Color.SkyBlue;
                ColocaRP4.Text = "-";
                ColocaRP4.Font = new Font(ColocaRP4.Font.Name, 32, FontStyle.Italic);
                ColocaRP4.BackColor = Color.Beige;
                ColocaRP4.Name = "Adivinando" + INValorDeLetra.ToString();
                FLP2.Controls.Add(ColocaRP4);

            }
















        }

    }

}
