using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;

namespace jccajamarcaExamen.Vistas;

public partial class vResumen : ContentPage
{
	public vResumen(string nombre, string usuario, string apellido, string edad, string montoIni, string pagoMen)
	{
		InitializeComponent();
        lbUsuario.Text = "Usuario conectado " + usuario;
        lblNombre.Text = nombre;
        lblApellido.Text = apellido;
        lblEdad.Text = edad;
        lblMontIni.Text = montoIni;
        lblPagoMen.Text = pagoMen;
    }

    private void btnCerrarSesion_Clicked(object sender, EventArgs e)
    {

    }
}