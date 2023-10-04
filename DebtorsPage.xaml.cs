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

        private void OnAddDebtorClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(DebtorNameEntry.Text) && int.TryParse(DebtorAmountEntry.Text, out int amount))
            {
                // Add the new debtor to the collection
                Debtors.Add(new Debtor { Name = DebtorNameEntry.Text, Amount = amount });

                // Clear the input fields after adding
                DebtorNameEntry.Text = string.Empty;
                DebtorAmountEntry.Text = string.Empty;
            }
            else
            {
                // Handle invalid input (optional)
                // Display an error message or provide feedback to the user
            }
        }
    }
}