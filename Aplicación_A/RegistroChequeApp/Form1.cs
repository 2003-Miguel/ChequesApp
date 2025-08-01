using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RegistroChequeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string carpetaCheques = @"C:\Cheques\";
            string carpetaFacturas = @"C:\Facturas\";

            if (!Directory.Exists(carpetaCheques) || !Directory.Exists(carpetaFacturas))
            {
                MessageBox.Show("Debe crear las carpetas necesarias antes de registrar el cheque.\nUse el botón 'Crear Carpetas'.");
                return;
            }

            // Validar campos vacíos y formato
            if (string.IsNullOrWhiteSpace(txtNumeroCheque.Text))
            {
                MessageBox.Show("Debe ingresar el número de cheque.");
                return;
            }
            if (!long.TryParse(txtNumeroCheque.Text, out long numeroChequeVal) || numeroChequeVal < 0)
            {
                MessageBox.Show("El número de cheque debe ser un número entero y no negativo.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtConcepto.Text))
            {
                MessageBox.Show("Debe ingresar el concepto.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Debe ingresar la cédula.");
                return;
            }
            if (!Regex.IsMatch(txtCedula.Text, @"^\d{11}$") || !long.TryParse(txtCedula.Text, out long cedulaVal) || cedulaVal < 0)
            {
                MessageBox.Show("La cédula debe contener exactamente 11 dígitos numéricos y no puede ser negativa.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFactura.Text))
            {
                MessageBox.Show("Debe ingresar el número de factura.");
                return;
            }
            if (!long.TryParse(txtFactura.Text, out long numeroFacturaVal) || numeroFacturaVal < 0)
            {
                MessageBox.Show("El número de factura debe ser un número entero y no negativo.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMontoNum.Text))
            {
                MessageBox.Show("Debe ingresar el monto numérico.");
                return;
            }
            if (!decimal.TryParse(txtMontoNum.Text, out decimal montoVal) || montoVal < 0)
            {
                MessageBox.Show("El monto numérico debe ser un valor decimal y no negativo.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMontoLetra.Text))
            {
                MessageBox.Show("Debe ingresar el monto en letras.");
                return;
            }

            // Todos los campos válidos, usar las cadenas originales para guardar y pasar parámetros
            string numeroCheque = txtNumeroCheque.Text;
            string concepto = txtConcepto.Text;
            string cedula = txtCedula.Text;
            string fecha = dtpFechaPago.Value.ToShortDateString();
            string montoNum = txtMontoNum.Text;
            string montoLetra = txtMontoLetra.Text;
            string factura = txtFactura.Text;

            string rutaArchivo = @"C:\Cheques\registro.txt";
            Directory.CreateDirectory(Path.GetDirectoryName(rutaArchivo));
            File.AppendAllText(rutaArchivo, $"Cheque: {numeroCheque}, Cliente: {cedula}, Fecha: {fecha}, Monto: {montoNum} ({montoLetra}), Factura: {factura}\n");

            // Crear imagen ficticia de la factura
            string rutaImagen = $@"C:\Facturas\{cedula}.png";
            Directory.CreateDirectory(Path.GetDirectoryName(rutaImagen));
            using (Bitmap bmp = new Bitmap(300, 100))
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                Font fuente = new Font("Arial", 12);
                Brush brocha = Brushes.Black;

                g.DrawString($"Cédula: {cedula}", fuente, brocha, new PointF(10, 10));
                g.DrawString($"Última factura: {factura}", fuente, brocha, new PointF(10, 40));

                bmp.Save(rutaImagen);
            }

            // Ejecutar App B pasando la cédula (como string)
            try
            {
                string rutaAppB = @"C:\Facturas\VisorFacturaApp.exe";
                Process.Start(rutaAppB, cedula);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la factura: " + ex.Message);
            }

            MessageBox.Show("Cheque registrado correctamente.");
        }
        private void btnCrearCarpetas_Click(object sender, EventArgs e)
        {
            string carpetaCheques = @"C:\Cheques\";
            string carpetaFacturas = @"C:\Facturas\";

            bool carpetaChequesExistente = Directory.Exists(carpetaCheques);
            bool carpetaFacturasExistente = Directory.Exists(carpetaFacturas);

            if (!carpetaChequesExistente)
                Directory.CreateDirectory(carpetaCheques);

            if (!carpetaFacturasExistente)
                Directory.CreateDirectory(carpetaFacturas);

            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string rutaOrigenAppB = Path.Combine(basePath, @"..\..\..\..\Aplicación_B\VisorFacturaApp\bin\Debug\VisorFacturaApp.exe");
            rutaOrigenAppB = Path.GetFullPath(rutaOrigenAppB);

            string rutaDestinoAppB = Path.Combine(carpetaFacturas, "VisorFacturaApp.exe");

            try
            {
                bool ejecutableExistente = File.Exists(rutaDestinoAppB);

                File.Copy(rutaOrigenAppB, rutaDestinoAppB, true);

                string mensaje = "Proceso completado:\n";
                mensaje += carpetaChequesExistente ? "- La carpeta 'Cheques' ya existía.\n" : "- Carpeta 'Cheques' creada.\n";
                mensaje += carpetaFacturasExistente ? "- La carpeta 'Facturas' ya existía.\n" : "- Carpeta 'Facturas' creada.\n";
                mensaje += ejecutableExistente
                    ? "- El ejecutable ya existía y fue reemplazado correctamente."
                    : "- Ejecutable copiado correctamente.";

                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al copiar VisorFacturaApp.exe:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarCarpetas_Click(object sender, EventArgs e)
        {
            string carpetaCheques = @"C:\Cheques\";
            string carpetaFacturas = @"C:\Facturas\";

            DialogResult confirmacion = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar las carpetas?\n\n" +
                "Esta acción borrará todos los registros de cheques y facturas guardados.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    bool existeCheques = Directory.Exists(carpetaCheques);
                    bool existeFacturas = Directory.Exists(carpetaFacturas);

                    if (!existeCheques && !existeFacturas)
                    {
                        MessageBox.Show("Las carpetas no existen, no hay nada que eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (existeCheques)
                    {
                        Directory.Delete(carpetaCheques, true);
                    }

                    if (existeFacturas)
                    {
                        Directory.Delete(carpetaFacturas, true);
                    }

                    MessageBox.Show("Las carpetas fueron eliminadas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al eliminar las carpetas:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Eliminación cancelada.", "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}