using TraficLight.ViewModels;

namespace TraficLight
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageVM();
        }

    
    }

}
