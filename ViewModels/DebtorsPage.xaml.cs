using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Assignment1.Data;
using Assignment1.DataModels;
using Microsoft.Maui.Controls;

namespace Assignment1
{
    public partial class DebtorsPage : ContentPage
    {
        private readonly Database _database;

        public DebtorsPage()
        {
            InitializeComponent();

            // Initialize the Debtors collection with some sample data
            var Debtors = App.DebtorsCollectionService.Debtors;

            Debtors = new ObservableCollection<Debtor> 
            {
                new Debtor { ID = 1, Name = "Nik", Amount = 500 },
                new Debtor { ID = 2, Name = "Alex", Amount = 250 },
                new Debtor { ID = 3, Name = "Joakim", Amount = 75 },
            };

            // Initialize the database context
            _database = new Database();

            // Set the ListView's ItemsSource to the Debtors collection
            DebtorsListView.ItemsSource = Debtors;
        }

        private async Task Initialize()
        {
            var debtors = await _database.GetDebtors();
            foreach (var debtor in debtors)
            {
                App.DebtorsCollectionService.Debtors.Add(debtor);
            }
        }

        //public async Task CompleteDebtor(Debtor debtor)
        //{
        //    var completed = await _database.UpdateDebtor(debtor);
        //    OnPropertyChanged(nameof(Debtors));
        //}

        //public async Task SwipeCompleteDebtorExecute(Debtor debtor)
        //{
        //    debtor.Done = true;
        //    var completed = await _database.UpdateDebtor(debtor);
        //}

        public async Task DeleteDebtorExecute(Debtor debtor)
        {
            var deleted = await _database.DeleteDebtor(debtor);
            if (deleted != 0)
            {
                App.DebtorsCollectionService.Debtors?.Remove(debtor);
            }
        }


    }
}