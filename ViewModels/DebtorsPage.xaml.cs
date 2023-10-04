using System;
using System.Collections.ObjectModel;
using Assignment1.DataModels;
using Microsoft.Maui.Controls;

namespace Assignment1
{
    public partial class DebtorsPage : ContentPage
    {
        public ObservableCollection<Debtor> Debtors { get; set; }

        public DebtorsPage()
        {
            InitializeComponent();

            // Initialize the Debtors collection with some sample data
            Debtors = new ObservableCollection<Debtor>
            {
                new Debtor { Name = "Nik", Amount = 500 },
                new Debtor { Name = "Alex", Amount = 250 },
                new Debtor { Name = "Joakim", Amount = 75 },
            };

            // Set the ListView's ItemsSource to the Debtors collection
            DebtorsListView.ItemsSource = Debtors;
        }

    }
}