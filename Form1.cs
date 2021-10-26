using System;
using System.Windows.Forms;

namespace Madis_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Conjuncion

        private void btnVerificar_Click(object sender, EventArgs e)
        {
             String neg;
            neg = txtNegar.Text.ToUpper();

            if(neg == "V")
            {
                lblResult.Text = "F";
            }
            else
            {
                lblResult.Text = "V";
            }
        }

        //Conjuncion..
        //en este proceso podemos notar que al introducir (f) y (v) obtenemos F
        private void btnConjunto_Click(object sender, EventArgs e)
        {
            String c1, c2;
            c1 = txtConjuncion.Text.ToUpper();
            c2 = txtConjuncion2.Text.ToUpper();
            
            if (c1 == "V" && c2 == "V")
            {
                lblResult2.Text = "V";
            }
            else
            {
                lblResult2.Text = "F";
            }
        }

        //sin utilizar.........///////////////////
        private void txtConjuncion2_TextChanged(object sender, EventArgs e)
        {

        }

        //disyuncion..
        //al introducir v y f podemos obtener v
        private void btnDisyuncion_Click(object sender, EventArgs e)
        {
            String dis1, dis2;


            dis1 = txtDis.Text.ToUpper();
            dis2 = txtDis2.Text.ToUpper();

            if(dis1 == "V" && dis2 == "F")
            {
                lblResultado3.Text = "V";

            }if(dis1 == "F" && dis2 == "V")
            {
                lblResultado3.Text = "V";
            }
            else
            {
                lblResultado3.Text = "F";
            }
        }

        //Condicional..
        //en este proceso podemos notar que al introducir v y f no da f
        private void button1_Click(object sender, EventArgs e)
        {

            String a, b;
            a = txtCondi.Text.ToUpper();
            b = txtCondi2.Text.ToUpper();

            if (a == "V" && b == "V" || b == "F" && a == "F" || a == "F" && b == "V")
            {
                lblResultado5.Text = "V";
            }
            else
            {
                lblResultado5.Text = "F";
            }
        }        

        //Bicondicional
        //al introducir v y f nos da (f)
        private void btnBicondicion_Click(object sender, EventArgs e)
        {
            String bicon1, bicon2;

            bicon1 = txtBicon.Text.ToUpper();
            bicon2 = txtBicon2.Text.ToUpper();

            if (bicon1 == "V" && bicon2 == "V" || bicon1 == "F" && bicon2 == "F")
            {
                lblResult6.Text = "V";
            }

            else
            {
                lblResult6.Text = "F";
            }

        }
    }
}
