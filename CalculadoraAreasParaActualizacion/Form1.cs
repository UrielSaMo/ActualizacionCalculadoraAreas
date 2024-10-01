using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CalculadoraAreasActualizado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelTriangulo.Visible = false;
            panelCuadrado.Visible = false;
            panelCirculo.Visible = false;
            panelRombo.Visible = false;
            panelRomboide.Visible = false;
        }
        private void buttonCuadrado_Click(object sender, EventArgs e)
        {
            MostrarPanel(panelCuadrado);
        }

        private void buttonTriangulo_Click(object sender, EventArgs e)
        {
            MostrarPanel(panelTriangulo);
        }
        private void buttonCirculo_Click(object sender, EventArgs e)
        {
            MostrarPanel(panelCirculo);
        }
        private void buttonRombo_Click_1(object sender, EventArgs e)
        {
            MostrarPanel(panelRombo);
        }

        private void buttonRomboide_Click_1(object sender, EventArgs e)
        {
            MostrarPanel(panelRomboide);
        }
        private void MostrarPanel(Panel panelSeleccionado)
        {
            // Oculta todos los paneles
            panelTriangulo.Visible = false;
            panelCuadrado.Visible = false;
            panelCirculo.Visible = false;
            panelRomboide.Visible = false;
            panelRombo.Visible = false;

            // Muestra el panel seleccionado
            panelSeleccionado.Visible = true;
        }

        private void buttonCalcularCirculo_Click(object sender, EventArgs e)
        {
            double res, radio;

            string texto = textBoxRadio.Text;
            bool NumeroValido = double.TryParse(textBoxRadio.Text, out radio);

            if (Regex.IsMatch(texto, @"^\d+(\.\d+)?$"))
            {
                if (NumeroValido)
                {
                    if (radio > 0)
                    {
                        res = radio * radio * Math.PI;
                        textBoxResultadoCirculo.Text = res.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El radio debe ser mayor que 0.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido (sin caracteres especiales o letras).");
            }
        }

        private void buttonCalcularPerimetroCirculo_Click(object sender, EventArgs e)
        {
            double res, radio;

            string texto = textBoxRadio.Text;
            bool NumeroValido = double.TryParse(textBoxRadio.Text, out radio);

            if (Regex.IsMatch(texto, @"^\d+(\.\d+)?$"))
            {
                if (NumeroValido)
                {
                    if (radio > 0)
                    {
                        res = (radio * 2) * Math.PI;
                        textBoxResultadoCirculo.Text = res.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El valor del radio debe ser mayor que 0.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido (sin caracteres especiales o letras).");
            }
        }
        private void buttonCalcularRombo_Click_1(object sender, EventArgs e)
        {
            double baseT, altura, res;

            string texto = textBoxDiametroM.Text;
            string texto2 = textBoxDiametroMenor.Text;

            bool NumeroValido = double.TryParse(textBoxDiametroM.Text, out baseT);
            bool NumeroValido2 = double.TryParse(textBoxDiametroMenor.Text, out altura);

            if (Regex.IsMatch(texto, @"^\d+(\.\d+)?$") && Regex.IsMatch(texto2, @"^\d+(\.\d+)?$"))
            {
                if (NumeroValido && NumeroValido2)
                {
                    baseT = double.Parse(textBoxDiametroM.Text);
                    altura = double.Parse(textBoxDiametroMenor.Text);
                    res = (baseT * altura) / 2;
                    textBoxResultadoRombo.Text = res.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido (sin caracteres especiales o letras).");
            }
        }
        private void buttonPerimetroRombo_Click_1(object sender, EventArgs e)
        {
            double lado, res;
            string texto = textBoxLadorombo.Text;
            bool NumeroValido = double.TryParse(textBoxLadorombo.Text, out lado);

            if (Regex.IsMatch(texto, @"^\d+(\.\d+)?$"))
            {
                if (NumeroValido)
                {
                    if (lado > 0)
                    {
                        lado = double.Parse(textBoxLadorombo.Text); 
                        res = lado * 4;
                        textBoxResultadoRombo.Text = res.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El valor del lado debe ser mayor que 0.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido (sin caracteres especiales o letras).");
            }
        }

        private void buttonCalcularRomboide_Click_1(object sender, EventArgs e)
        {
            double baseT, altura, res;

            string texto = textBoxBaseR.Text;
            string texto2 = textBoxAlturaR.Text;

            bool NumeroValido = double.TryParse(textBoxBaseR.Text, out baseT);
            bool NumeroValido2 = double.TryParse(textBoxAlturaR.Text, out altura);

            if (Regex.IsMatch(texto, @"^\d+(\.\d+)?$") && Regex.IsMatch(texto2, @"^\d+(\.\d+)?$"))
            {
                if (NumeroValido && NumeroValido2)
                {
                    baseT = double.Parse(textBoxBaseR.Text);
                    altura = double.Parse(textBoxAlturaR.Text);
                    res = baseT * altura;
                    textBoxResultadoRomboide.Text = res.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido (sin caracteres especiales o letras).");
            }
        }
        private void buttonPerimetroRomboide_Click(object sender, EventArgs e)
        {
            double ladoM, ladom, res;

            string texto = textBoxRomboideLM.Text;
            string texto2 = textBoxRomboideLadom.Text;

            bool NumeroValido = double.TryParse(textBoxRomboideLM.Text, out ladoM);
            bool NumeroValido2 = double.TryParse(textBoxRomboideLadom.Text, out ladom);

            if (Regex.IsMatch(texto, @"^\d+(\.\d+)?$") && Regex.IsMatch(texto2, @"^\d+(\.\d+)?$"))
            {
                if (NumeroValido && NumeroValido2)
                {
                    ladoM = double.Parse(textBoxRomboideLM.Text);
                    ladom = double.Parse(textBoxRomboideLadom.Text);
                    res = (ladoM * 2) + (ladom * 2);
                    textBoxResultadoRomboide.Text = res.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido (sin caracteres especiales o letras).");
            }
        }

        private void buttonCalcularCuadrado_Click(object sender, EventArgs e)
        {
            double lado, res;
            string texto = textBoxCuadradoLado.Text;
            bool NumeroValido = double.TryParse(textBoxCuadradoLado.Text, out lado);

            if (Regex.IsMatch(texto, @"^\d+(\.\d+)?$"))
            {
                if (NumeroValido)
                {
                    if (lado > 0)
                    {
                        res = lado * lado;
                        textBoxResultadoCuadrado.Text = res.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El valor del lado debe ser mayor que 0.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido (sin caracteres especiales o letras).");
            }
        }

        private void buttonCalcularPerimetroCuadrado_Click(object sender, EventArgs e)
        {
            double lado, res;
            string texto = textBoxCuadradoLado.Text;
            bool NumeroValido = double.TryParse(textBoxCuadradoLado.Text, out lado);

            if (Regex.IsMatch(texto, @"^\d+(\.\d+)?$"))
            {
                if (NumeroValido)
                {
                    if (lado > 0)
                    {
                        res = lado * 4;
                        textBoxResultadoCuadrado.Text = res.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El valor del lado debe ser mayor que 0.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido (sin caracteres especiales o letras).");
            }
        }

        private void buttonCalcularTriangulo_Click(object sender, EventArgs e)
        {
            double baseT, altura, res;

            string texto = textBoxBase.Text;
            string texto2 = textBoxAltura.Text;

            bool NumeroValido = double.TryParse(textBoxBase.Text, out baseT);
            bool NumeroValido2 = double.TryParse(textBoxAltura.Text, out altura);

            if (Regex.IsMatch(texto, @"^\d+(\.\d+)?$") && Regex.IsMatch(texto2, @"^\d+(\.\d+)?$"))
            {
                if (NumeroValido && NumeroValido2)
                {
                    if (baseT > 0 && altura > 0)
                    {
                        res = (baseT * altura) / 2;
                        textBoxResultadoTriangulo.Text = res.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Los valores deben ser mayores que 0.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido (sin caracteres especiales o letras).");
            }
        }


        private void buttonCalcularPerimetroTriangulo_Click(object sender, EventArgs e)
        {
            double lado1, lado2, lado3, res;
            string texto = textBoxLado1.Text;
            string texto2 = textBoxLado2.Text;
            string texto3 = textBoxLado3.Text;

            bool NumeroValido = double.TryParse(textBoxLado1.Text, out lado1);
            bool NumeroValido2 = double.TryParse(textBoxLado2.Text, out lado2);
            bool NumeroValido3 = double.TryParse(textBoxLado3.Text, out lado3);

            if (Regex.IsMatch(texto, @"^\d+(\.\d+)?$") &&
                Regex.IsMatch(texto2, @"^\d+(\.\d+)?$") &&
                Regex.IsMatch(texto3, @"^\d+(\.\d+)?$"))
            {
                if (NumeroValido && NumeroValido2 && NumeroValido3)
                {
                    if (lado1 > 0 && lado2 > 0 && lado3 > 0)
                    {
                        res = lado1 + lado2 + lado3;
                        textBoxResultadoTrianguloP.Text = res.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Los lados deben ser mayores que 0.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa números válidos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa números válidos (sin caracteres especiales o letras).");
            }
        }

       
    }
}
