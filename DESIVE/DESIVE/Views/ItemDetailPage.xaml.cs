using DESIVE.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DESIVE.Views
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