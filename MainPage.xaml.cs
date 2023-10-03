namespace Assignment1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        //Sender user til siden DeptorsPage
        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DebtorsPage());
        }
    }
}