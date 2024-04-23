namespace jccajamarcaExamen.Vistas;

public partial class vRegistro : ContentPage
{
	public vRegistro(string usuario)
	{
		InitializeComponent();
        lbUsuario.Text = "Usuario conectado " + usuario;
    }

    private void pkPais_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void pkCiudad_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        if (pkPais.SelectedIndex == -1)
        {
            DisplayAlert("Alerta", "Seleccione una Ciudad", "cerrar");
        }
        else
        {
            try
            {
                Double montIni = float.Parse(txtMontoIni.Text);
                Double pagoMen;
                {
                    pagoMen = ((3000 - montIni) + ((5*3000)/100))/3;
                    string pagoMenR = pagoMen.ToString("F2");
                    txtPagoMen.Text = pagoMenR.ToString();
                }

            }
            catch
            {
                resultado.Text = "Error en la captura de datos";
            }

        }
    }

    private async void btnResumen_Clicked(object sender, EventArgs e)
    {

        string nombre = txtNombre.Text;
        string usuario = lbUsuario.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;
        string montoIni = txtMontoIni.Text;
        string pagoMen = txtPagoMen.Text;
        await Navigation.PushAsync(new vResumen(nombre, usuario, apellido, edad, montoIni, pagoMen ));

    }
}