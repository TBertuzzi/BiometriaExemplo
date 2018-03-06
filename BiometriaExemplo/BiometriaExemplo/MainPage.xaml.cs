using Plugin.Fingerprint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BiometriaExemplo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            
            btnAutenticar.Clicked += async (sender, e) => {

                var result = await CrossFingerprint.Current.AuthenticateAsync("É você mesmo?");
                if (result.Authenticated)
                {
                    lbAutenticado.Text = "Autenticado!";
                }
                else
                {
                    lbAutenticado.Text = "Atenção: Este app esta sendo roubado ligue imediatamente para carsystem";
                }

            };
        }
	}
}
