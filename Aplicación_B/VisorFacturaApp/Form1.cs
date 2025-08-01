using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace VisorFacturaApp
{
    public partial class Form1 : Form
    {
        string[] archivosFacturas;
        int indiceActual = 0;

        public Form1()
        {
            InitializeComponent();

            archivosFacturas = Directory.GetFiles(@"C:\Facturas\", "*.png");

            string[] args = Environment.GetCommandLineArgs();
            string cedula = args.Length > 1 ? args[1] : "";

            if (!string.IsNullOrEmpty(cedula))
            {
                for (int i = 0; i < archivosFacturas.Length; i++)
                {
                    if (Path.GetFileNameWithoutExtension(archivosFacturas[i]).Contains(cedula))
                    {
                        indiceActual = i;
                        break;
                    }
                }
            }
            else
            {
                indiceActual = 0;
            }

            CargarFactura(indiceActual);
        }

        private void CargarFactura(int indice)
        {
            if (indice >= 0 && indice < archivosFacturas.Length)
            {
                pictureBoxFactura.Image?.Dispose();
                pictureBoxFactura.Image = Image.FromFile(archivosFacturas[indice]);
                pictureBoxFactura.SizeMode = PictureBoxSizeMode.Zoom;

                ActualizarBotonesNavegacion();
            }
        }

        private void ActualizarBotonesNavegacion()
        {
            btnAnterior.Enabled = indiceActual > 0;
            btnSiguiente.Enabled = indiceActual < archivosFacturas.Length - 1;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indiceActual > 0)
            {
                indiceActual--;
                CargarFactura(indiceActual);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (indiceActual < archivosFacturas.Length - 1)
            {
                indiceActual++;
                CargarFactura(indiceActual);
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (indiceActual >= 0 && indiceActual < archivosFacturas.Length)
            {
                string rutaRegistro = @"C:\Cheques\registro.txt";

                if (File.Exists(rutaRegistro))
                {
                    string nombreArchivo = Path.GetFileNameWithoutExtension(archivosFacturas[indiceActual]);
                    string[] lineas = File.ReadAllLines(rutaRegistro);

                    List<string> lineasCoincidentes = new List<string>();
                    foreach (string linea in lineas)
                    {
                        if (linea.Contains(nombreArchivo))
                        {
                            lineasCoincidentes.Add(linea);
                        }
                    }

                    if (lineasCoincidentes.Count == 0)
                    {
                        MessageBox.Show("No se encontró información del cheque para la cédula: " + nombreArchivo);
                        return;
                    }

                    string mensaje = "Detalles encontrados para la cédula " + nombreArchivo + ":\n\n";
                    foreach (var detalle in lineasCoincidentes)
                    {
                        string[] partes = detalle.Split(',');
                        foreach (var parte in partes)
                        {
                            mensaje += parte.Trim() + "\n";
                        }
                        mensaje += "\n---\n";
                    }

                    MessageBox.Show(mensaje, "Detalles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró el archivo de registro de cheques.");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
