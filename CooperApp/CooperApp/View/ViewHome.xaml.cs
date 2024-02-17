using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CooperApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewHome : ContentView
    {
        public static BindableProperty PontoAtendimentoProperty = BindableProperty.Create("PontoAtendimento", typeof(string), typeof(ViewHome));
        public static BindableProperty QuantidadePassageiroProperty = BindableProperty.Create("QuantidadePassageiro", typeof(string), typeof(ViewHome));
        public static BindableProperty MotoristaPaProperty = BindableProperty.Create("MotoristaPa", typeof(string), typeof(ViewHome));
        public static BindableProperty MotoriDistanciaPastaPaProperty = BindableProperty.Create("MotoriDistanciaPastaPa", typeof(string), typeof(ViewHome));
        public static BindableProperty DistanciaPaoProperty = BindableProperty.Create("DistanciaPa", typeof(string), typeof(ViewHome));
        public static BindableProperty corStatusProperty = BindableProperty.Create("corStatus", typeof(Color), typeof(ViewHome));

        public string PontoAtendimento {
            get { return (string)GetValue(PontoAtendimentoProperty); } 
            set { SetValue(PontoAtendimentoProperty,value); } 
        }
        public string QuantidadePassageiro {
            get { return (string)GetValue(QuantidadePassageiroProperty); }
            set { SetValue(QuantidadePassageiroProperty, value); }
        }
        public string MotoristaPa {
            get { return (string)GetValue(MotoristaPaProperty); }
            set { SetValue(MotoristaPaProperty, value); }
        }
        public string MotoriDistanciaPastaPa {
            get { return (string)GetValue(MotoriDistanciaPastaPaProperty); }
            set { SetValue(MotoriDistanciaPastaPaProperty, value); }
        }
        public string DistanciaPa {
            get { return (string)GetValue(DistanciaPaoProperty); }
            set { SetValue(DistanciaPaoProperty, value); }
        }
        public Color corStatus {
            get { return (Color)GetValue(corStatusProperty); }
            set { SetValue(corStatusProperty, value); }
        }
        public ViewHome()
        {
            InitializeComponent();
        }
    }
}