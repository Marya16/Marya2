namespace Marya2;

public partial class MainPage : ContentPage
{
	results Resultado;
	public MainPage() 
	{
		Resultado= new results();
		InitializeComponent();
		TestandoLayout();
		PreencherTela();
	}
	void TestandoLayout()
	{
		Resultado.temp=32;
		Resultado.city="Apucarana, PR";
		Resultado.description="Ensolarado";
		Resultado.rain=0;
		Resultado.humidity=2%;
		Resultado.sunrise="5:40 am";
		Resultado.sunset="18:50 pm";
		Resultado.wind_speedy="3.99 km/h";
		Resultado.wind_direction=30;
		Resultado.moon_phase="Nova";
		Resultado.currently="Dia";
		Resultado.codition_code="25";
		Resultado.img_id="26";
		Resultado.cloudiness=14;
		Resultado.wind_cardinal="S";
	
	}
}

