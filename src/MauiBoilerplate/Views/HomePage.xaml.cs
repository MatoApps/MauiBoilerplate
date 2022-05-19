using Abp.Dependency;
using MauiBoilerplate.ViewModels;

namespace MauiBoilerplate
{
    public partial class HomePage : ContentPageBase, ITransientDependency
    {
        public HomePage(HomePageViewModel nowPlayingPageViewModel)
        {
            InitializeComponent();
            this.BindingContext = nowPlayingPageViewModel;
        }
    }
}
