using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcu
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //PARAMETROS    
        double valor1 = 0;
        double valor2 = 0;
        string operacion;
        bool igual = false;
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                LimpiarCampo();
                igual = false;
            }
            txt_pantalla.Text += "5";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                LimpiarCampo();
                igual = false;
            }
            txt_pantalla.Text += "6";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                LimpiarCampo();
                igual = false;
            }
            txt_pantalla.Text += "4";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                LimpiarCampo();
                igual = false;
            }
            txt_pantalla.Text += "9";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                LimpiarCampo();
                igual = false;
            }
            txt_pantalla.Text += "8";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                LimpiarCampo();
                igual = false;
            }
            txt_pantalla.Text += "7";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                LimpiarCampo();
                igual = false;
            }
            txt_pantalla.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                LimpiarCampo();
                igual = false;
            }
            txt_pantalla.Text += "3";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                LimpiarCampo();
                igual = false;
            }
            txt_pantalla.Text += "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampo();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btn_multiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "x";
            if (txt_pantalla.Text != "")
            {
                valor1 = double.Parse(txt_pantalla.Text);
                txt_pantalla.Text = "";
            }
            else
            {
                Error();
            }
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            operacion = "÷";
            if (txt_pantalla.Text != "")
            {
                valor1 = double.Parse(txt_pantalla.Text);
                txt_pantalla.Text = "";
            }
            else
            {
                Error();
            }
                
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            if (txt_pantalla.Text != "")
            {
                valor1 = double.Parse(txt_pantalla.Text);
                txt_pantalla.Text = "";
            }
            else
            {
                Error();
            }
            
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            if (txt_pantalla.Text != "")
            {
                valor1 = double.Parse(txt_pantalla.Text);
                txt_pantalla.Text = "";
            }
            else
            {
                Error();
            }
        }

        private void btn_raiz_Click(object sender, EventArgs e)
        {

        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            igual = true;
            double res = 0;
            if (txt_pantalla.Text == "")
            {
                Error();
            }
            else
            {
                valor2 = double.Parse(txt_pantalla.Text);
                switch (operacion)
                {
                    case "+":
                        
                        res = valor1 + valor2;
                        break;

                    case "-":
                        res = valor1 - valor2;
                        break;

                    case "x":
                        res = valor1 * valor2;
                        break;

                    case "÷":
                        if (valor2 == 0)
                        {
                            MessageBox.Show("No es posible dividir entre 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            res = valor1 / valor2;
                        }
                        break;
                    default:
                        res = 0;
                        MessageBox.Show("Debe ingrese al menos dos valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                }
                txt_pantalla.Text = res.ToString();
            }

        }//btn igual fin

        private void btn_punto_Click(object sender, EventArgs e)
        {

        }

        private void btn_porcentaje_Click(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (igual)
            {
                LimpiarCampo(); 
                igual = false;  
            }
            txt_pantalla.Text += "0"; 
        }

        //eventos

        public void LimpiarCampo()
        {
            valor1 = 0;
            valor2 = 0;
            txt_pantalla.Text = "";
        }
        
        public void Error()
        {
            MessageBox.Show("Debes ingresar almenos 1 valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
