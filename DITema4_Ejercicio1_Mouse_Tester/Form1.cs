#define VALOR
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
        bool teclas = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void coordenadas(object sender, MouseEventArgs e)
        {
            if (!teclas)
            {
                this.x = e.X;
                this.y = e.Y;
                this.Text = String.Format("Coordenadas X:{0}-Y:{1}", x, y);
            }
            
        }

        private void coordenadasBotones(object sender, MouseEventArgs e)
        {

            if (!teclas)
            {
                Button boton = (Button)sender;
                this.x = boton.Location.X + e.X;
                this.y = boton.Location.Y + e.Y;
                this.Text = String.Format("Coordenadas X:{0}-Y:{1}", x, y);
            }
            

        }

        private void AbandonarForm(object sender, EventArgs e)
        {
            if (!teclas)
            {
                this.Text = "Mouse Tester";
            }
        }

        private void cklickraton(object sender, MouseEventArgs e)
        {
            this.button1.BackColor = default;
            this.button2.BackColor = default;

            if (e.Button == MouseButtons.Left)
            {
                this.button1.BackColor = Color.Beige;
            }
            else if(e.Button == MouseButtons.Right)
            {
                this.button2.BackColor = Color.Coral;
            }else
            {
                this.button1.BackColor = Color.Aqua;
                this.button2.BackColor = Color.Aqua;
            }
        }

        private void previewTecla(object sender, PreviewKeyDownEventArgs e)
        {
            Console.WriteLine("fuck");
            teclas = true;
            this.Text = e.KeyCode.ToString();
            if(e.KeyCode == Keys.Escape)
            {
                teclas = false;
            }
        }

        private void Prueba(object sender, KeyEventArgs e)
        {

            teclas = true;
#if VALOR
            this.Text = e.KeyValue.ToString();
#else
            this.Text = e.KeyCode.ToString();
#endif

            if (e.KeyCode == Keys.Escape)
            {
                teclas = false;
            }
        }

        private void Segurito(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Segurito qué quieres salir?","Aplicación",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
