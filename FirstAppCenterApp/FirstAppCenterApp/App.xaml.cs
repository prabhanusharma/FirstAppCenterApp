﻿using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstAppCenterApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=90bf8591-e34e-4e59-8027-e531e9d9e4f7;", 
                typeof(Analytics), typeof(Crashes));

        }


        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
