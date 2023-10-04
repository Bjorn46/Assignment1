using System;
using System.Collections.ObjectModel;
using Assignment1.DataModels;
using Microsoft.Maui.Controls;

namespace Assignment1
{
    public partial class addDebtor : ContentPage
    {

        public addDebtor()
        {
            InitializeComponent();


        }

        private async void OnAddDebtorClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new addDebtor());
        }
    }
}