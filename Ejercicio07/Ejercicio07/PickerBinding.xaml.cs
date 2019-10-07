using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio07
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerBinding : ContentPage
    {
        public PickerBinding()
        {
            InitializeComponent();
            BindingContext = new MonkeysPageViewModel();
        }
    }
}