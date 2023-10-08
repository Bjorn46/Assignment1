using System;
using System.Collections.ObjectModel;
using Assignment1.Data;
using Assignment1.DataModels;
using Assignment1.ViewModels;
using Microsoft.Maui.Controls;

namespace Assignment1
{
    public partial class addDebtor : ContentPage
    {
        private readonly Database _database;
        public addDebtor()
        {
            InitializeComponent();
            
            // Initialize the database context
            _database = new Database();

            var Debtors = App.DebtorsCollectionService.Debtors;
        }

        //public ObservableCollection<Debtor> Debtors { get; set; } = new();
        private async void OnAddDebtorClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new addDebtor());
        }

        private async Task Initialize()
        {
            var debtors = await _database.GetDebtors();
            foreach (var debtor in debtors)
            {
                App.DebtorsCollectionService.Debtors.Add(debtor);
            }
        }

        public async Task AddNewDebtor()
        {
            var debtor = new Debtor
            {
                // Initialize debtor properties here
            };
            var inserted = await _database.AddDebtor(debtor);
            if (inserted != 0)
            {
                App.DebtorsCollectionService.Debtors.Add(debtor);
                // Clear input fields and raise property change notifications as needed
            }
        }

    }
}