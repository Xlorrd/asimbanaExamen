namespace asimbanaExamen.Vistas;

public partial class registro : ContentPage
{
	public registro(string usuario)
	{
		InitializeComponent();
        lblUsuario.Text = $"Bienvenido {usuario}";
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
    double monto=Convert.ToDouble(txtMontoInicial.Text);
        
        double porcentaje = 1500 * 0.4;
        double pagoMensual = (1500 - monto / 4) + porcentaje;
        double pagoTotal= monto+pagoMensual*4;
        txtPagoMensual.Text= Convert.ToString(pagoMensual);
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        string fecha = datePicker.Date.ToString("d");
        string pais = pickerPais.SelectedItem?.ToString();
        string ciudad = pickerCiudad.SelectedItem?.ToString();
        string montoInicial = txtMontoInicial.Text;
        string pagoMensual = txtPagoMensual.Text;

        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;

        string mensaje = $"Resumen:\n\n" +
                     $"Nombre: {nombre}\n" +
                     $"Apellido: {apellido}\n" +
                     $"Edad: {edad}\n\n" +
                     $"Fecha: {fecha}\n" +
                     $"Ciudad: {ciudad}\n" +
                     $"País: {pais}\n" +
                     $"Monto Inicial: {montoInicial}\n" +
                     $"Pago Mensual: {pagoMensual}\n";

        DisplayAlert("Datos Capturados", mensaje, "OK");
    }
}