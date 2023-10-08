

using Assignment1.ViewModels;

namespace Assignment1
{
    public partial class App : Application
    {
        public static DebtorsCollectionService DebtorsCollectionService { get; private set; }
        public App()
        {
            InitializeComponent();
            DebtorsCollectionService = new DebtorsCollectionService();

            MainPage = new AppShell();
            //MainPage = new NavigationPage(new DebtorsPage());
        }
    }
}