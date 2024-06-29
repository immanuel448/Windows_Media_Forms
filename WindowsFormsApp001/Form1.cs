using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp001
{
    public partial class Form1 : Form, Interface1
    {
        public Form1()
        {
            InitializeComponent();
            media001.settings.volume = 99;
            media001.settings.autoStart = false;
            activarBotones(false);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnRepro_Click(object sender, EventArgs e)
        {
            Reproducir();
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            Pausar();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            Parar();
        }

        private void activarBotones(bool eleccion)
        {
            btnRepro.Enabled = eleccion;
            btnPausar.Enabled = eleccion;
            btnParar.Enabled = eleccion;
        }

        public void cargar()
        {
            try
            {
                string ruta = "";
                if (file001.ShowDialog() == DialogResult.OK)
                {
                    ruta = file001.FileName;
                    try
                    {
                        media001.URL = ruta;
                        activarBotones(true);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de la excepción: puedes mostrar un mensaje de error al usuario o registrar la excepción para depuración
                MessageBox.Show("Se produjo un error al cargar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                activarBotones(false);
            }
        }

        public void Reproducir()
        {
            try
            {
                media001.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al reproducir este archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                activarBotones(false);
            }
        }
        public void Pausar()
        {
            try
            {
                media001.Ctlcontrols.pause();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al pausar este archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                activarBotones(false);
            }
        }
        public void Parar()
        {
            try
            {
                media001.Ctlcontrols.stop();
                activarBotones(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al parar este archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                activarBotones(false);
            }
        }
    }
}
