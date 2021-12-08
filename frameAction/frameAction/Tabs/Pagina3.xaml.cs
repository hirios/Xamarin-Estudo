using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace frameAction
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina3 : ContentPage
    {

        public ObservableCollection<PopularFashion> popularFashion { get; set; }

        public Pagina3()
        {
            InitializeComponent();
            popularFashion = new ObservableCollection<PopularFashion>
            {
                new PopularFashion{Name="Blusa", Price="R$: 18, 80", Picture="https://raw.githubusercontent.com/LeomarisReyes/FashionUI/master/FashionUI.Android/Resources/drawable/Model2.png"},
                new PopularFashion{Name="Short", Price="R$: 18, 80", Picture="https://raw.githubusercontent.com/LeomarisReyes/FashionUI/master/FashionUI.Android/Resources/drawable/Model3.png"},
                new PopularFashion{Name="Tênis", Price="R$: 18, 80", Picture="https://raw.githubusercontent.com/LeomarisReyes/FashionUI/master/FashionUI.Android/Resources/drawable/Model1.png"}
            };
            BindingContext = this;
        }

        public class PopularFashion
        {
            public string Name { get; set; }
            public string Price { get; set; }
            public string Picture { get; set; }
        }
    }
}