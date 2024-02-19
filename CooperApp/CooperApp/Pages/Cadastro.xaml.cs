using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CooperApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
            InitializeComponent();

            Entry entryCPF = new Entry();
            entryCPF.TextChanged += EntryCPF_TextChanged;

            Entry entryTelefone = new Entry();
            entryTelefone.TextChanged += EntryCel_TextChanged;

        }

        private void EntryCPF_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                if (e.NewTextValue.Length == 3 || e.NewTextValue.Length == 7)
                {
                    ((Entry)sender).Text += ".";
                }
                else if (e.NewTextValue.Length == 11)
                {
                    ((Entry)sender).Text += "-";
                }
            }

        }

        private void EntryCel_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                if (e.NewTextValue.Length == 1)
                {
                    ((Entry)sender).Text = "(" + e.NewTextValue;
                }
                else if (e.NewTextValue.Length == 3)
                {
                    ((Entry)sender).Text += ") ";
                }
                else if (e.NewTextValue.Length == 10)
                {
                    ((Entry)sender).Text += "-";
                }
            }

        }
    }
}