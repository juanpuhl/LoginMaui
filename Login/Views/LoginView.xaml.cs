namespace Login.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
	}

    private async void CrearUsuario_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new CrearUsuarioView());	
    }
}