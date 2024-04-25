using System.Reflection.Emit;

namespace Marya2;

public partial class MainPage : ContentPage
{
	Results Resultado;
	public MainPage() 
	{
		Resultado = new Results();
		InitializeComponent();
		TestandoLayout();
		PreencherTela();
	}
	void TestandoLayout()
	{
		Resultado.temp=32;
		Resultado.city="Apucarana, PR";
		Resultado.description="Ensolarado";
		Resultado.rain=1;
		Resultado.humidity=2;
		Resultado.sunrise="5:40 am";
		Resultado.sunset="18:50 pm";
		Resultado.wind_speedy="3.99 kmh";
		Resultado.wind_direction=30;
		Resultado.moon_phase="Nova";
		Resultado.currently="Dia";
		Resultado.codition_code="25";
		Resultado.img_id="26";
		Resultado.cloudiness=14;
		Resultado.wind_cardinal="S";
	
	}
	void PreencherTela()
	{
		Labeltemp.Text = Resultado.temp. ToString();
		Labelcity.Text = Resultado.city;
		Labeldescription.Text = Resultado.description;
		Labelrain.Text = Resultado.rain.ToString();
		Labelhumidity.Text = Resultado.humidity.ToString();
		Labelsunrise.Text = Resultado.sunrise;
		Labelsunset.Text = Resultado.sunset;
		Labelwind_speedy.Text = Resultado.wind_speedy;
		Labelwind_direction.Text = Resultado.wind_direction.ToString();
			
	}


}

