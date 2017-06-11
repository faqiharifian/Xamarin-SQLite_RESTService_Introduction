using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Modul5_Practice
{
    public partial class App : Application
    {
        private static DataAccess dbUtils;

        public App()
        {
            InitializeComponent();

            //MainPage = new Modul5_Practice.MainPage();
            MainPage = new NavigationPage(new ManageEmployee());
        }

        public static DataAccess DBUtils
        {
            get
            {
                if (dbUtils == null)
                {
                    dbUtils = new DataAccess();
                }
                return dbUtils;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
