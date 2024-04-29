
using System.Text.Json;


namespace Marya2;

public partial class MainPage : ContentPage
{
	Results Resultado;

	const string url ="https://api.hgbrasil.com/weather?woeid=455927&key=1d4672ff";
	Resposta resposta;
	public MainPage() 
	{
		InitializeComponent();
		AtualizaTempo();
	}
	
	async void AtualizaTempo()
	{
	   try
	  {
      var navegador = new HttpClient();
	  var response = await navegador.GetAsync (url);
	  if (response.IsSuccessStatusCode)
	  {
		var content = await response.Content.ReadAsStringAsync();
		resposta = JsonSerializer.Deserialize<Resposta>(content);
	  }
	    PreencherTela();
	  }	 
		catch(Exception e)
      { 

	  }
	}

	void PreencherTela()
	{
		Labeltemp.Text = resposta.results.temp.ToString();
		Labelcity.Text = resposta.results.city;
		Labeldescription.Text = resposta.results.description;
		Labelrain.Text = resposta.results.rain.ToString();
		Labelhumidity.Text = resposta.results.humidity.ToString();
		Labelsunrise.Text = resposta.results.sunrise;
		Labelsunset.Text = resposta.results.sunset;
		Labelwind_speedy.Text = resposta.results.wind_speedy;
		Labelwind_direction.Text = resposta.results.wind_direction.ToString();
		Labeldafasedalua.Text= resposta.results.moon_phase;

		if(resposta.results.moon_phase=="full") 
			Labeldafasedalua.Text = "Cheia";
		else if(resposta.results.moon_phase=="new")	
		    Labeldafasedalua.Text = "Nova";
		else if(resposta.results.moon_phase=="growing")	
		    Labeldafasedalua.Text = "Crescente";
		else if(resposta.results.moon_phase=="waning")
            Labeldafasedalua.Text = "Minguante";
	  	else if(resposta.results.moon_phase=="waning_gibbous")
            Labeldafasedalua.Text = "Gibosa Minguante";
	   else 
	    Labeldafasedalua.Text = "Gibosa Crescente";

		if (resposta.results.currently=="dia")
		{
			if (resposta.results.rain > 10)
				imgfundo.Source="diachuvoso.png";
			else if (resposta.results.cloudiness > 10)
				imgfundo.Source="dianublado.png";
			else
				imgfundo.Source="dialimpo.png";
		}	
		else
		{
			if (resposta.results.rain > 10)
				imgfundo.Source="noitechuvosa.png";
			else if (resposta.results.cloudiness > 10)
				imgfundo.Source="noitenublada.png";
			else
				imgfundo.Source="noitelimpa.png";
		}
	}
}

