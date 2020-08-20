using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CBT1.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        private string username;

        public string Username
        {
            get { return username; }
            set {
                SetProperty(ref username, value); }
            
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private readonly IRegionManager _regionManager;
        public DelegateCommand<string> NavigateCommand { get; set; }

        public LoginViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }


        public void Navigate(string uri)
        {
            if (Username != null && Password != null)
            {
                _regionManager.RequestNavigate("contentArea", uri);
                return;
            }
            MessageBox.Show("you must enter your username and password inorder to login", "Input Error!");
        }
     
    }
}
