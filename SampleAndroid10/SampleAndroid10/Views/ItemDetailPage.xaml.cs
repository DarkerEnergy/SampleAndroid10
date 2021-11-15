using SampleAndroid10.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SampleAndroid10.Views
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