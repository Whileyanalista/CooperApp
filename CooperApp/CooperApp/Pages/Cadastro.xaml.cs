using System;
using Xamarin.Essentials;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CooperApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastro : ContentPage
    {

        double maxVerticalScrollDistance = 140; // Limitando Scroll
        double scrollDistance = 550; // Define a distância que você deseja percorrer durante a animação


        public Cadastro()
        {
            InitializeComponent();
            rdchekbox();

            scrollcad.Scrolled += OnScrollViewScrolled;


            Entry entryCPF = new Entry();
            entryCPF.TextChanged += EntryCPF_TextChanged;

            Entry entryTelefone = new Entry();
            entryTelefone.TextChanged += EntryCel_TextChanged;

        }

        private void OnScrollViewScrolled(object sender, ScrolledEventArgs e)
        {
            // Verifica se o deslocamento horizontal é maior que o valor máximo permitido
            if (e.ScrollY > maxVerticalScrollDistance)
            {
                scrollcad.ScrollToAsync(scrollcad.ScrollX, maxVerticalScrollDistance, false);

            }

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

        private async void rdchekbox ()
        {
            // Cria uma animação de deslocamento da scroll
            
            if (rdmotorista.IsChecked == true)
            {
                frameCadPasseiro.IsVisible = false;
                frameCadVeiculo.IsVisible = true;

                Animation scrollAnimation = new Animation(v => scrollcad.ScrollToAsync(0, 550, true), scrollcad.ScrollX, scrollDistance);

                // Define a duração da animação em milissegundos
                scrollAnimation.Commit(this, "ScrollAnimation", 16, 500, Easing.Linear);


                await Task.WhenAll(
                   frameCadVeiculo.FadeTo(1, 1000),
                   btCadastro.TranslateTo(0, +410, 500, Easing.Linear),
                   frameCadVeiculo.TranslateTo(0, -70, 500, Easing.Linear), 
                   scrollcad.ScrollToAsync(scrollcad.ScaleX, maxVerticalScrollDistance=scrollDistance, true)
                   );
            }
            else if (rdparceiro.IsChecked == true)
            {
                frameCadVeiculo.IsVisible = false;
                frameCadPasseiro.IsVisible = true;

                Animation scrollAnimation = new Animation(v => scrollcad.ScrollToAsync(0, 550, true), scrollcad.ScrollX, scrollDistance);

                // Define a duração da animação em milissegundos
                scrollAnimation.Commit(this, "ScrollAnimation", 16, 500, Easing.Linear);


                await Task.WhenAll(
                   frameCadPasseiro.FadeTo(1, 1000),
                   btCadastro.TranslateTo(0, +360, 500, Easing.Linear),
                   frameCadPasseiro.TranslateTo(0, -70, 500, Easing.Linear),
                   scrollcad.ScrollToAsync(scrollcad.ScaleX, maxVerticalScrollDistance = scrollDistance, true)
                   );
                
            }
            else if (rdlusuario.IsChecked == true)
            {
                Animation scrollAnimation = new Animation(v => scrollcad.ScrollToAsync(0, 140, true), scrollcad.ScrollX, scrollDistance);

                // Define a duração da animação em milissegundos
                scrollAnimation.Commit(this, "ScrollAnimation", 16, 500, Easing.Linear);


                frameCadVeiculo.IsVisible = false;
                frameCadPasseiro.IsVisible = false;

                await Task.WhenAll(
                   frameCadVeiculo.FadeTo(0, 1000),
                   frameCadPasseiro.FadeTo(0,1000),
                   btCadastro.TranslateTo(0, 0, 500, Easing.Linear),
                   scrollcad.ScrollToAsync(scrollcad.ScaleX, maxVerticalScrollDistance, true)                   
                   );               

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
                    foreach (var file in result.FileName)
                    {
                        arquivo_ = result.FileName;
                    }                   

                    if (butArquivo.Text == "Selecione o Documento do veiculo")
                    {
                        selectedCarEntry.Text = $"Arquivo :{ arquivo_}";

                        butArquivo.Text = "Selecione a Habilitaçao";
                    }
                    else if (butArquivo.Text == "Selecione a Habilitaçao")
                    {
                        selectedHabEntry.Text = $"Arquivo :{ arquivo_}";

                        butArquivo.Text = "Selecione o Documento do veiculo";
                    }                   

                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private async void DocVeiculop_onClicked(object sender, EventArgs e)
        {

            try
            {
                var result1 = await FilePicker.PickAsync(new PickOptions
                {
                    FileTypes = FilePickerFileType.Png, // ou especifique os tipos de arquivo desejados
                    PickerTitle = "Nome do arquivo"
                });


                var arquivo1_ = "";
                foreach (var file in result1.FileName)
                {
                    arquivo1_ = result1.FileName;
                }

                if (butArquivop.Text == "Selecione a logo da empresa")
                {
                    selectedPassEntryp.Text = $"Arquivo :{ arquivo1_}";
                }               
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void selectedHabEntry_Focused(object sender, FocusEventArgs e)
        {
            butArquivo.Text = "Selecione a Habilitaçao";
            selectedHabEntry.Unfocus();

        }

        private void selectedCarEntry_Focused(object sender, FocusEventArgs e) 
        {        
            butArquivo.Text = "Selecione o Documento do veiculo";
            selectedCarEntry.Unfocus();
        }

        private void selectedCarEntryp_Focused(object sender, FocusEventArgs e)
        {
            butArquivop.Text = "Selecione a logo da empresa";
            selectedPassEntryp.Unfocus();
        }

        private void Rdtipousuario_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            rdchekbox();
        }
    }

}