﻿
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MySCADA_Xamarin
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MainScreen), typeof(MainScreen));

        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
        }
    }
}
