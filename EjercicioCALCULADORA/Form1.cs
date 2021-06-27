using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioCALCULADORA
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        double num2 = 0;
        char operador;
        public Form1()
        {
            InitializeComponent();
        }
        private void ingresarNum(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if  (pantalla.Text=="0")
            {
                pantalla.Text = "";
            }
            pantalla.Text += boton.Text;
        }
        private void operaciones(object sender, EventArgs e)
        {
            var boton = ((Button)sender); //obtenemos el boton en elcual se hizo click
            num1 = Convert.ToDouble(pantalla.Text);
            operador = Convert.ToChar(boton.Text);

            pantalla.Text = "0";
            //aqui limpiamos colocando un cero cuando presiona un operador
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(pantalla.Text);

            if (operador == '+')
            {
                pantalla.Text = (num1 + num2).ToString();
                num1 = Convert.ToDouble(pantalla.Text);
            }

            if (operador == '-')
            {
                pantalla.Text = (num1 - num2).ToString();
                num1 = Convert.ToDouble(pantalla.Text);
            }

            if (operador == 'x')
            {
                pantalla.Text = (num1 * num2).ToString();
                num1 = Convert.ToDouble(pantalla.Text);
            }

            if (operador == '/')
            {
                pantalla.Text = (num1 / num2).ToString();
                num1 = Convert.ToDouble(pantalla.Text);
            }
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            if (!pantalla.Text.Contains("."))
            {
                pantalla.Text += ".";
            }
        }

        private void btnCambiarSigno_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(pantalla.Text);
            num2 *= -1;
            pantalla.Text = num1.ToString();
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operador = '\0';
            pantalla.Text = "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            pantalla.Text = "0";
        }

        private void btnBorrarUno_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Length > 1)
            {
                pantalla.Text = pantalla.Text.Substring(0, pantalla.Text.Length - 1);
            }
            else
            {
                pantalla.Text = "0";
            }
        }
    }
}
