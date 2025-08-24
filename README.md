# ChequesApp

**ChequesApp** es una aplicación de escritorio desarrollada en **C# con Windows Forms**, que permite registrar cheques emitidos por clientes, asociarlos a facturas, y gestionar sus datos de forma organizada. También incluye una herramienta para visualizar facturas asociadas a través de su número de cédula.

## Funcionalidades

### Registro de Cheques
- Captura de número de cheque, concepto, cédula, fecha, montos (numérico y en letras), y número de factura.
- Validaciones de campos obligatorios y formatos numéricos válidos.
- Creación automática de carpetas `C:\Cheques\` y `C:\Facturas\`.
- Guardado de registros en archivo `.txt`.

### Visor de Facturas
- Búsqueda de imágenes asociadas a la cédula del cliente.
- Visualización de imágenes desde la carpeta `C:\Facturas\`.
- Interfaz limpia para navegar entre resultados.

## Tecnologías utilizadas

- Lenguaje: C# (.NET Framework)
- Interfaz: Windows Forms
- Archivos locales: `.txt` para registros y `.jpg/.png` para facturas
