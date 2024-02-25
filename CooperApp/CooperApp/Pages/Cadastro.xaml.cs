using System;
using Xamarin.Essentials;
using System;
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

        private async void DocVeiculo_onClicked(object sender, EventArgs e)
        {
            try
            {
                
                var result = await FilePicker.PickAsync(new PickOptions
                {
                    FileTypes = FilePickerFileType.Pdf, // ou especifique os tipos de arquivo desejados
                    PickerTitle = "Nome do arquivo"
                });
                                

                if (result != null)
                {
                    var arquivo_ = "";
                    // Faça o que for necessário com o arquivo selecionado
                    foreach(var file in result.FileName)
                    {
                        arquivo_ = result.FileName;
                    }

                    if (butArquivo.Text == "Selecione o Documento do veiculo")
                    {
                        selectedCarEntry.Text = $"Arquivo :{ arquivo_}";

                        butArquivo.Text = "Selecione a Habilitaçao";
                    } 
                    else if(butArquivo.Text == "Selecione a Habilitaçao")
                    {
                        selectedHabEntry.Text = $"Arquivo :{ arquivo_}";

                        butArquivo.Text = "Selecione o Documento do veiculo";
                    }                  
                    
                }
            }
            catch (Exception ex)
            {
                // Trate exceções, se necessário
            }
        }

        private void selectedHabEntry_Focused(object sender, FocusEventArgs e)
        {
            butArquivo.Text = "Selecione a Habilitaçao";
        }

        private void selectedCarEntry_Focused(object sender, FocusEventArgs e) 
        { 
       
            butArquivo.Text = "Selecione o Documento do veiculo";
            //selectedCarEntry.Keyboard = Keyboard.Create(KeyboardFlags.All);

        }
    }

}