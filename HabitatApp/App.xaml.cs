﻿using HabitatApp.View;

namespace HabitatApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LandingPage());
        }
    }
}