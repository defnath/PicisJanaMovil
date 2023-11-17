using Movil.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Movil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard : ContentPage
    {
        VMGraphicPh objs;

        public Dashboard()
        {
            InitializeComponent();
            objs = new VMGraphicPh();
            BindingContext = objs;
        }

        /* async void Button_Changed(object sender, EventArgs e)
        {

            int x = 0;
            while(x < 5){
                Changed();
                x++;
                await Task.Delay(2000);
            } 
        }

        private void Changed()
        {
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                objs.Data[i].Ph = random.Next(2, 8);
                objs.Data[i].Hour = random.Next(2, 8);
            }
        }*/
    }
}