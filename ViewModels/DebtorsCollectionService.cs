using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.DataModels;

namespace Assignment1.ViewModels
{
    public class DebtorsCollectionService
    {
        public ObservableCollection<Debtor> Debtors { get; private set; }
        
        public DebtorsCollectionService()
        {
            Debtors = new ObservableCollection<Debtor>();
        }
    } 
}
