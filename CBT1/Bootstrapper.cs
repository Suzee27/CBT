using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CBT1.Views;
using Microsoft.Practices.Unity;


namespace CBT1
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
            
        }
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            Container.RegisterType(typeof(object), typeof(LoginView), "LoginView");
            Container.RegisterType(typeof(object), typeof(QuestionView), "QuestionView");
            Container.RegisterType(typeof(object), typeof(ScoreView), "ScoreView");
            // Container.RegisterType(typeof(object), typeof(QuestionView), "QuestionView");
        }


    }
}
