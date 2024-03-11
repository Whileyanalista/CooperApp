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
    public partial class ViewParceiroMotorista : ContentView
    {

        public static BindableProperty corStatusMotoristaProperty = BindableProperty.Create("corStatusMotorista", typeof(Color), typeof(ViewParceiroMotorista));
        public static BindableProperty motoristaNomeProperty = BindableProperty.Create("motoristaNome", typeof(string), typeof(ViewParceiroMotorista));
        public static BindableProperty corSheckProperty = BindableProperty.Create("corSheck", typeof(Color), typeof(ViewParceiroMotorista));
        public static BindableProperty corStatusTextProperty = BindableProperty.Create("corStatusText", typeof(Color),typeof(ViewParceiroMotorista));
        public static BindableProperty statusMotoristasProperty = BindableProperty.Create("statusMotoristas", typeof(string), typeof(ViewParceiroMotorista));
        public static BindableProperty dadosMotoristaProperty = BindableProperty.Create("dadosMotorista", typeof(string), typeof(ViewParceiroMotorista));


        public Color corStatusMotorista
        {
            get { return (Color)GetValue(corStatusMotoristaProperty); }
            set { SetValue(corStatusMotoristaProperty, value); }
        }
        public string motoristaNome
        {
            get { return (string)GetValue(motoristaNomeProperty); }
            set { SetValue(motoristaNomeProperty, value); }
        }        
        public Color corSheck
        {
            get { return (Color)GetValue(corSheckProperty); }
            set { SetValue(corSheckProperty, value); }
        }
        public Color corStatusText
        {
            get { return (Color)GetValue(corStatusTextProperty); }
            set { SetValue(corStatusTextProperty, value); }
        }
        public string statusMotoristas
        {
            get { return (string)GetValue(statusMotoristasProperty); }
            set { SetValue(statusMotoristasProperty, value); }
        }
        public string dadosMotorista
        {
            get { return (string)GetValue(dadosMotoristaProperty); }
            set { SetValue(dadosMotoristaProperty, value); }
        }        

        public ViewParceiroMotorista()
        {
            InitializeComponent();
        }
    }
}