using System.ComponentModel;
using Xamarin.Forms;
using XOapp.ViewModels;

namespace XOapp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}