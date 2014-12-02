using System.Windows;
using Application.Desktop;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Module.Hello; 

class Bootstrapper : UnityBootstrapper
{
	protected override DependencyObject CreateShell()
	{
		return new Shell();
	}

	protected override void InitializeShell()
	{
		base.InitializeShell();

		App.Current.MainWindow = (Window)this.Shell;
		App.Current.MainWindow.Show();
	}

	protected override void ConfigureModuleCatalog()
	{
		base.ConfigureModuleCatalog();
		
		var moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
		moduleCatalog.AddModule(typeof(HelloModule));
		
		//WhenAvailable exits as well... somewhere
	}
}