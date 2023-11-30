using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2u4
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
        //declaracion de variable de cantidad 
        int cantidadhamburgesa;
        int cantidadhotdog;
        int cantidadsandwich;
        int cantidadte;
        int cantidadrefreco;
        int cantidadpapas;

        double totaVta;
        double costohamburgesa;
        double costohotdog;
        double costosandwich;
        double costote;
        double costorefresco;
        double costopapas;

        //inicializar las variables con los precios de los productos 
        double hamburgesa = 20.5;
        double hotdog = 19.25;
        double sandwich = 17.5;
        double papasfritas = 4.5;
        double refresco = 4;
        double te = 5;

      

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //paquete No.1 de comida 
            textBox7.Text = ""; 
            if (radioButton1.Checked == true ) 
            {
                cantidadhamburgesa = 1;
                cantidadrefreco = 1;
                cantidadpapas = 1;
                cantidadhotdog = 0;
                cantidadsandwich = 0;
                cantidadte = 0;
                //inicializar valores 
                textBox1.Text = cantidadhamburgesa.ToString();
                textBox5.Text = cantidadrefreco.ToString();
                textBox6.Text = cantidadpapas.ToString();

                //acvtivar las cajas de texto del paquete 
                textBox1.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                // desactivar las otras cajas 
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                //limpiar las cajas de texto 
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = ""; 

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // paquete 2 
            textBox7.Text = ""; 
            if (radioButton2.Checked == true )
            {
                cantidadrefreco = 1; 
                cantidadpapas = 1;
                cantidadhotdog = 1;
                cantidadsandwich= 0;
                // inicializar valores 
                textBox2.Text = cantidadhotdog.ToString();
                textBox5.Text= cantidadrefreco.ToString();
                textBox6.Text= cantidadpapas.ToString();
                //activar las cajas de texto del paquete
                textBox2.Enabled = true;
                textBox5 .Enabled = true;
                textBox6.Enabled = true;
                //desactivar las otras cajas 
                textBox1.Enabled = false;
                textBox3 .Enabled = false;
                textBox4.Enabled = false;
                //limpiar las cajas de texto 
                textBox2.Text = "";
                textBox1.Text = "";
                textBox3.Text = "";
                
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // paquete No. de comida 
            textBox7.Text = ""; 
            if (radioButton3.Checked == true )
            {
                cantidadhotdog = 0;
                cantidadrefreco = 1;
                cantidadpapas = 1;
                cantidadhotdog = 0;
                cantidadsandwich = 1;
                cantidadte = 0;
                //inicializar valores 
                textBox3.Text= cantidadsandwich.ToString();
                textBox5.Text = cantidadrefreco.ToString();
                textBox6.Text = cantidadpapas.ToString();
                //activar las cajas texto del paquete 
                textBox3.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                //desactivar las otras cajas 
                textBox2 .Enabled = false;
                textBox1.Enabled = false;
                textBox4 .Enabled = false;
                //limpiar caja de texto 
                textBox1.Text = "";
                textBox6.Text = "";
                textBox2.Text = "";

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //opcion otro pedido 
            textBox7.Text = "";
            if (radioButton4.Checked == true )
            {
                //habilitar todas las entradas 
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                /*
                 * txhamburgesa.text = "";
                 * txhotdog.text = "";
                 * txsandwich.text = "";
                 * txte.text= "";
                 * txrefresco.text = "";
                 * txpapas.text = "";*/
                double cantidadhamburguesa = int .Parse(textBox1.Text);
                double cantidadhotdog = int .Parse(textBox2.Text);
                double cantidadsandwich = int .Parse(textBox3.Text);
                double cantidadte = int .Parse(textBox4.Text);
                double cantidadrefresco = int .Parse(textBox5.Text);
                double cantidadpapas = int .Parse(textBox6.Text);
             
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //multiplicando la cantidad por el precio y sumando el total 
            costohamburgesa = (cantidadhamburgesa * hamburgesa);
            costohotdog = (cantidadhotdog * hotdog);
            costosandwich = (cantidadsandwich * sandwich);
            costote = (cantidadte * te);
            costorefresco = (cantidadrefreco * refresco);
            costopapas = (cantidadpapas * papasfritas);
            totaVta = costohamburgesa + costohotdog + costosandwich + costorefresco + costopapas + costote;
            textBox7.Text = totaVta.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
