//using Prism.Commands;
//using Prism.Mvvm;
//using Prism.Navigation;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Xamarin_test_ver2.ViewModels
//{
//    public class ViewModelBase : BindableBase, INavigationAware, IDestructible
//    {
//        public void OnNavigatedFrom(INavigationParameters parameters)
//        {
//            throw new NotImplementedException();
//        }

//        public void OnNavigatedTo(INavigationParameters parameters)
//        {
//            throw new NotImplementedException();
//        }

//        public void OnNavigatingTo(INavigationParameters parameters)
//        {
//            throw new NotImplementedException();
//        }

//        public void Destroy()
//        {
//            throw new NotImplementedException();
//        }

//        protected INavigationService    { get; private set; }

//        private string _title;
//        public string Title
//        {
//            get { return _title; }
//            set { SetProperty(ref _title, value); }
//        }

//        public ViewModelBase(INavigationService navigationService)
//        {
//            NavigationService = navigationService;
//        }

//        public virtual void OnNavigatedFrom(INavigationParameters parameters)
//        {

//        }

//        public virtual void OnNavigatedTo(INavigationParameters parameters)
//        {

//        }

//        public virtual void OnNavigatingTo(INavigationParameters parameters)
//        {

//        }

//        public virtual void Destroy()
//        {

//        }
//    }
//}
