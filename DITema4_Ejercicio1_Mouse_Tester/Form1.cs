//#define VALOR
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DITema4_Ejercicio1_Mouse_Tester
{
    public partial class Form1 : Form
    {
        public int x;
        public int y;


        public Form1()
        {
            InitializeComponent();
        }

        private void coordenadas(object sender, MouseEventArgs e)
        {
           
                this.x = e.X;
                this.y = e.Y;
                this.Text = String.Format("Coordenadas X:{0}-Y:{1}", x, y);
            
            
        }

        private void coordenadasBotones(object sender, MouseEventArgs e)
        {

           
                Button boton = (Button)sender;
                this.x = boton.Location.X + e.X;
                this.y = boton.Location.Y + e.Y;
                this.Text = String.Format("Coordenadas X:{0}-Y:{1}", x, y);
           
            

        }

        private void AbandonarForm(object sender, EventArgs e)
        {
                this.Text = "Mouse Tester";
            
        }


        private void previewTecla(object sender, PreviewKeyDownEventArgs e)
        {
            Console.WriteLine("fuck");
            this.Text = e.KeyCode.ToString();
            if(e.KeyCode == Keys.Escape)
            {
                this.Text = "Mouse Tester";
            }
        }



         private void Prueba(object sender, KeyEventArgs e)
        {
#if VALOR
            this.Text = e.KeyValue.ToString();
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = "Mouse Tester";
            }
#endif
        }
            private void PruebaPress(object sender, KeyPressEventArgs e)
        {
#if !VALOR
            this.Text =Convert.ToString(e.KeyChar);
            if (e.KeyChar == 27)
            {
                this.Text = "Mouse Tester";
            }
#endif
        }




        private void Segurito(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Segurito qué quieres salir?","Aplicación",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void HagoClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.button1.BackColor = Color.Crimson;
            }
            else if (e.Button == MouseButtons.Right)
            {
                this.button2.BackColor = Color.Coral;
            }
            else
            {
                this.button1.BackColor = Color.DarkGreen;
                this.button2.BackColor = Color.DarkGreen;
            }
        }

        private void QuitoClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.button1.BackColor = default;
            }
            else if (e.Button == MouseButtons.Right)
            {
                this.button2.BackColor = default;
            }
            else
            {
                this.button1.BackColor = default;
                this.button2.BackColor = default;
            }
        }
    }
}
