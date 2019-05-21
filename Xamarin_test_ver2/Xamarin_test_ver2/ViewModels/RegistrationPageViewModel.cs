using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;
using Prism.Mvvm;
using System.Windows.Input;
using Xamarin_test_ver2.Views;

namespace Xamarin_test_ver2.ViewModels
{
    public class RegistrationPageViewModel : BindableBase, INavigationService
    {
        #region fields
        protected INavigationService NavigationService { get; private set; }
        private readonly IPageDialogService PageDialogService;
        public DelegateCommand MoveToMainPageCommand { get; }
        public DelegateCommand ShowAlertCommand { get; }
        private string text;
        public string Text
        {
            get { return this.text; }
            set { SetProperty(ref this.text, value); }
        }
        #endregion
        public RegistrationPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
        {
            this.NavigationService = navigationService;
            MoveToMainPageCommand = new DelegateCommand(async () =>
            {
                await this.NavigationService.GoBackAsync();
            });

        }

        public Task<INavigationResult> GoBackAsync()
        {
            throw new NotImplementedException();
        }

        public Task<INavigationResult> GoBackAsync(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task<INavigationResult> NavigateAsync(Uri uri)
        {
            throw new NotImplementedException();
        }

        public Task<INavigationResult> NavigateAsync(Uri uri, INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task<INavigationResult> NavigateAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<INavigationResult> NavigateAsync(string name, INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
