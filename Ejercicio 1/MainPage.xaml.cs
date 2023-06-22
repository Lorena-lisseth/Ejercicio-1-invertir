namespace Ejercicio_1;
///<Summary>
///<Createddate>2023/06/20</Createddate>
///<company>SandBox</company>
///<lastmodificationdate>2023/06/21</lastmodificationdate>
///<lastmodificationdescription>
///Agregar mensaje de error
///</lastmodificationdescription>
///<lastmodifierautor>Lorena vasquez</lastmodifierautor>
///</Summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// constructor de la clase
	/// </summary>
	public MainPage()
	{
		InitializeComponent();
	}
	/// <summary>
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void CounterBtn_Clicked(object sender, EventArgs e)
	{
		//se ponen las variables desde el Dato1 hasta el 
		//Dato 4, para luego invertirlos desde Dato4 al 
		//Dato1, luego ponemos un DisplayAlert para enviar
		//un mesaje de error, tambien hacemos usos del String
		//IsNullOrEmpty para verificar si hay campos vacios.
		if (!string.IsNullOrEmpty(datoA.Text) && !string.IsNullOrEmpty(datoB.Text) &&
			!string.IsNullOrEmpty(datoC.Text) && !string.IsNullOrEmpty(datoD.Text))
		{
			double Dato1, Dato2, Dato3, Dato4;
			Dato1 = Convert.ToDouble(datoA.Text);
			Dato2 = Convert.ToDouble(datoB.Text);
			Dato3 = Convert.ToDouble(datoC.Text);
			Dato4 = Convert.ToDouble(datoD.Text);
			datoA.Text = Convert.ToString(Dato4);
			datoB.Text = Convert.ToString(Dato3);
			datoC.Text = Convert.ToString(Dato2);
			datoD.Text = Convert.ToString(Dato1);
		}
		else
		{
			DisplayAlert("Error", "Introduce todos los numeros", "ok");
		}

	}
}

