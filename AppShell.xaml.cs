namespace task_list_app_maui;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

	private void OnSearchClicked(object sender, EventArgs e)
	{
		DisplayAlert(Title, "Pesquisar Tarefas", "OK");
	}

	private void OnAboutClicked(object sender, EventArgs e)
	{
		DisplayAlert(Title, "Informações sobre o App Lista de Tarefas", "OK");
	}	
}
