using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace Module.Hello
{
    public class HelloModule : IModule
    {
	    private readonly IRegionManager _regionManager;

	    public HelloModule(IRegionManager regionManager)
	    {
		    _regionManager = regionManager;
	    }

	    public void Initialize()
			{
				_regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.HelloView));
			}
    }
}
