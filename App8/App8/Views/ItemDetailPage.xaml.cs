using App8.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace App8.Views
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