using lab4.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace lab4.Views
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