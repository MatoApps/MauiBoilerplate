using Abp.Dependency;

namespace MauiBoilerplate;

public partial class MainPage : Shell, ITransientDependency
{
    public MainPage(IocManager iocManager)
	{
		InitializeComponent();
        var page = iocManager.Resolve<HomePage>();
        this.HomePageShellContent.Content = page;
    }
}