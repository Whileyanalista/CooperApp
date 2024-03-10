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
    public partial class AlterSenha : ContentPage
    {
        public AlterSenha()
        {
            InitializeComponent();
            
        }

        private async void cadEmailFramEmail()
        {            

            if (framEmail.TranslationY == -350 && framWhats.TranslationY == -350)
            {
                await Task.WhenAll(
                  cadEmail.FadeTo(1, 1000),
                  framEmail.TranslateTo(0, -230, 500, Easing.Linear),
                  framWhats.TranslateTo(0, -230, 500, Easing.Linear)
                  );
            } 
            else if (framWhats.TranslationY == -230 && framEmail.TranslationY == -230)
            {
                await Task.WhenAll(
                     cadEmail.FadeTo(0, 500),
                     cadWats.FadeTo(1, 500),
                     framEmail.TranslateTo(0, -350, 500, Easing.Linear)
                     );
            }
            else if (framWhats.TranslationY == -230 && framEmail.TranslationY == -350)
            {
                await Task.WhenAll(
                      cadEmail.FadeTo(1, 500),
                      cadWats.FadeTo(0, 500),
                      framEmail.TranslateTo(0, -230, 500, Easing.Linear)
                      );
            }
        }

        private async void cadWhatsFramWhats()
        {

            if (framWhats.TranslationY == -350 && framWhats.TranslationY == -350)
            {
                await Task.WhenAll(
                  cadEmail.FadeTo(0, 500),
                  cadWats.FadeTo(1, 1000),
                  framWhats.TranslateTo(0, -230, 500, Easing.Linear)
                  );
            }
            else if (framWhats.TranslationY == -230 && framEmail.TranslationY == -350)
            {
                await Task.WhenAll(
                    cadEmail.FadeTo(0, 500),
                    cadWats.FadeTo(0, 500),
                    framWhats.TranslateTo(0, -350, 500, Easing.Linear)
                    );
            }
            else if (framWhats.TranslationY == -230 && framEmail.TranslationY == -230)
            {
                await Task.WhenAll(
                    cadEmail.FadeTo(0, 500),
                    cadWats.FadeTo(1, 1000),
                    framEmail.TranslateTo(0, -350, 500, Easing.Linear)
                    );
            }
        }



        private async void framEmail_OnFrameTapped(object sender, EventArgs e)
        {
            cadEmailFramEmail();
        }

        private async void framWhats_OnFrameTapped(object sender, EventArgs e)
        {
            cadWhatsFramWhats();
            //if (framWhats.TranslationY == -350)
            //{
            //    await Task.WhenAll(
            //      cadEmail.FadeTo(0, 1000),
            //      framWhats.TranslateTo(0, -119, 500, Easing.Linear)
            //      );                
            //}
            //else if(framEmail.TranslationY == -119)
            //{                
            //    await Task.WhenAll(
            //        cadEmail.FadeTo(0, 1000),
            //        framEmail.TranslateTo(0, -350, 500, Easing.Linear),
            //        framWhats.TranslateTo(0, -119, 500, Easing.Linear)
            //        );
            //}
            //else
            //{
            //    await Task.WhenAll(
            //       cadEmail.FadeTo(0, 1000),
            //       framEmail.TranslateTo(0, -190, 500, Easing.Linear),
            //       framWhats.TranslateTo(0, -190, 500, Easing.Linear)
            //       );
            //}
        }
    }
}