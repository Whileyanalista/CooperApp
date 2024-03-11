using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CooperApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewParceiro : ContentView
    {
        public static BindableProperty DadosParceirosProperty = BindableProperty.Create("DadosParceiros", typeof(string), typeof(ViewParceiro));
        public static BindableProperty ComponenteParceiroProperty = BindableProperty.Create("ComponenteParceiro", typeof(string), typeof(ViewParceiro));
        public static BindableProperty TipoDocProperty = BindableProperty.Create("TipoDoc", typeof(string), typeof(ViewParceiro));
        public static BindableProperty TipoDadoProperty = BindableProperty.Create("TipoDado", typeof(string), typeof(ViewParceiro));

        public string DadosParceiros
        {
            get { return (string)GetValue(DadosParceirosProperty); }
            set { SetValue(DadosParceirosProperty, value); }
        }

        public string ComponenteParceiro
        {
            get { return (string)GetValue(ComponenteParceiroProperty); }
            set { SetValue(ComponenteParceiroProperty, value); }
        }
        public string TipoDoc
        {
            get { return (string)GetValue(TipoDocProperty); }
            set { SetValue(TipoDocProperty, value); }
        }


        public string TipoDado
        {
            get { return (string)GetValue(TipoDadoProperty); }
            set { SetValue(TipoDadoProperty, value); }
        }

        public ViewParceiro()
        {
            InitializeComponent();
        }
        
    }
}