using Abp.Domain.Repositories;
using MauiBoilerplate.Core.Entities;
using MauiBoilerplate.Core.ViewModel;

namespace MauiBoilerplate.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        private readonly IRepository<Song, long> songRepository;

        public HomePageViewModel(IRepository<Song,long> songRepository)
        {
            this.songRepository=songRepository;
        }


    }
}
