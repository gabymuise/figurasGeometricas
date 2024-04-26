using figurasGeometrica.interfaces;
using figurasGeometrica.models;
using System;
using System.Windows.Forms;

namespace figurasGeometrica
{
    public partial class Form1 : Form
    {
        private enum TipoFigura
        {
            Cuadrado,
            Triangulo,
            Circulo
        }

        private TipoFigura figuraSeleccionada;

        public Form1()
        {
            InitializeComponent();
            ResetForm();
        }

        private void ResetForm()
        {
            OcultarTodosLosControles();
            MostrarControlesCuadrado();
            SeleccionarFigura(TipoFigura.Cuadrado);
        }

        private void OcultarTodosLosControles()
        {
            foreach (Control control in Controls)
            {
                if (control is Label || control is TextBox)
                {
                    control.Visible = true;
                }
            }
        }

        private void MostrarControlesCuadrado()
        {
            MostrarControles(lblLado1, txtLado1);
        }

        private void MostrarControlesTriangulo()
        {
            MostrarControles(lblLado1, txtLado1, lblLado2, txtLado2, lblLado3, txtLado3);
        }

        private void MostrarControlesCirculo()
        {
            MostrarControles(lblRadio, txtRadio);
        }

        private void MostrarControles(params Control[] controls)
        {
            foreach (var control in controls)
            {
                control.Visible = true;
            }
        }

        private void SeleccionarFigura(TipoFigura figura)
        {
            figuraSeleccionada = figura;
        }

        private void Calcular()
        {
            txtArea.Text = "";
            txtPerimetro.Text = "";
            txtAltura.Text = "";

            switch (figuraSeleccionada)
            {
                case TipoFigura.Cuadrado:
                    CalcularCuadrado();
                    break;
                case TipoFigura.Triangulo:
                    CalcularTriangulo();
                    break;
                case TipoFigura.Circulo:
                    CalcularCirculo();
                    break;
                default:
                    break;
            }
        }

        private void CalcularCuadrado()
        {
            if (decimal.TryParse(txtLado1.Text, out decimal ladoCuadrado))
            {
                Cuadrado cuadrado = new Cuadrado(ladoCuadrado);
                txtArea.Text = cuadrado.CalcularArea().ToString();
                txtPerimetro.Text = cuadrado.CalcularPerimetro().ToString();
            }
        }

        private void CalcularTriangulo()
        {
            if (decimal.TryParse(txtLado1.Text, out decimal lado1) &&
                decimal.TryParse(txtLado2.Text, out decimal lado2) &&
                decimal.TryParse(txtLado3.Text, out decimal lado3))
            {
                Triangulo triangulo = new Triangulo(lado1, lado2, lado3);
                txtArea.Text = triangulo.CalcularArea().ToString();
                txtPerimetro.Text = triangulo.CalcularPerimetro().ToString();
                txtAltura.Text = triangulo.CalcularAltura().ToString();
            }
        }

        private void CalcularCirculo()
        {
            if (double.TryParse(txtRadio.Text, out double radio))
            {
                Circulo circulo = new Circulo(radio);
                txtArea.Text = circulo.CalcularArea().ToString();
                txtPerimetro.Text = circulo.CalcularPerimetro().ToString();
            }
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            OcultarTodosLosControles();
            MostrarControlesCuadrado();
            SeleccionarFigura(TipoFigura.Cuadrado);
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            OcultarTodosLosControles();
            MostrarControlesTriangulo();
            SeleccionarFigura(TipoFigura.Triangulo);
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            OcultarTodosLosControles();
            MostrarControlesCirculo();
            SeleccionarFigura(TipoFigura.Circulo);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Calcular();
        }
    }
}
