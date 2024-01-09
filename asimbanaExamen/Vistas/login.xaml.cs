namespace asimbanaExamen.Vistas;

public partial class login : ContentPage
{
	public login()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        bool sessionUser = validacion(txtUsuario.Text, txtContrasena.Text);

        if (sessionUser)
        {
            Navigation.PushAsync(new registro(usuario));
        }
        else
        {
            DisplayAlert("Fallo", "Usuario u contraseña incorrecto", "Cancelar");
        }


    }
    private bool validacion(string usuario, string contrasena)
    {
        string[,] usuarios = new string[,]
        {
            {"estudiante2024","uisrael2024" },
            {"examen1","parcial1"},
            {"Ana","ana123" },
            {"asimbana","2024" }

        };
        bool Autentification = false;

        for (int i = 0; i < usuarios.GetLength(0); i++)
        {

            string usuarioActual = usuarios[i, 0];
            string contrasenaActual = usuarios[i, 1];

            if (usuario == usuarioActual && contrasena == contrasenaActual)
            {
                Autentification = true;

                break;
            }

        }
        return Autentification;
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Acerca de", "Creado por Alex Simbaña 8 \"A\" 2024", "OK");
    }
}
