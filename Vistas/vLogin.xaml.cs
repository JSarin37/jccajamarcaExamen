namespace jccajamarcaExamen.Vistas;

public partial class vLogin : ContentPage
{
    private List<(string username, string password)> _credentials = new List<(string username, string password)>
    {
        ("estudiante2024", "uisrael2024"),
        ("examen1", "parcial1"),
        ("NombreEstudiante", "2024")
    };
    public vLogin()
	{
		InitializeComponent();
        
    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string username = txtUsuario.Text;
        string password = txtContraseña.Text;

        if (IsAuthenticated(username, password))
        {
            // Login success
            LoginStatus.Text = "Login Successful!";
            Navigation.PushAsync(new vRegistro(username));
        }
        else
        {
            // Login failed
            LoginStatus.Text = "Invalid Username or Password";
        }
    }
    private bool IsAuthenticated(string username, string password)
    {
        return _credentials.Any(cred => cred.username == username && cred.password == password);
    }
    private void btnAcercade_Clicked(object sender, EventArgs e)
    {

    }
}