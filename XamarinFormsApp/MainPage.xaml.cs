using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinOperaciones
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void BotonSUMA(Object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Num1.Text) && ! string.IsNullOrEmpty(Num2.Text))
            {
                var num1 = double.Parse(Num1.Text);
                var num2 = double.Parse(Num2.Text);
                var total = num1 + num2;
                Total.Text = total.ToString();
                string mensaje = "";

                if (total > 0)
                {
                    mensaje = "Num Positivo++";
                }
                else
                {
                    mensaje = "Num Negativo--";
                }
                DisplayAlert("El resultado es", mensaje, "...");
            }
            else 
            {
                DisplayAlert("Error", "no se han puesto los números","Ok");
            }
        }
        private void BotonRESTA(Object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Num1.Text) && !string.IsNullOrEmpty(Num2.Text))
            {
                var num1 = double.Parse(Num1.Text);
                var num2 = double.Parse(Num2.Text);
                var total = num1 - num2;
                Total.Text = total.ToString();
                string mensaje = "";

                if (total > 0)
                {
                    mensaje = "Num Positivo++";
                }
                else
                {
                    mensaje = "Num Negativo--";
                }
                DisplayAlert("El resultado es", mensaje, "...");
            }
            else
            {
                DisplayAlert("Error", "no se han puesto los números", "Ok");
            }
        }
        private void BotonMULTIPLICAR(Object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Num1.Text) && !string.IsNullOrEmpty(Num2.Text))
            {
                var num1 = double.Parse(Num1.Text);
                var num2 = double.Parse(Num2.Text);
                var total = num1 * num2;
                Total.Text = total.ToString();
                string mensaje = "";

                if (total > 0)
                {
                    mensaje = "Num Positivo++";
                }
                else
                {
                    mensaje = "Num Negativo--";
                }
                DisplayAlert("El resultado es", mensaje, "...");
            }
            else
            {
                DisplayAlert("Error", "no se han puesto los números", "Ok");
            }
        }
        private void BotonDIVIDIR(Object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Num1.Text) && !string.IsNullOrEmpty(Num2.Text))
            {
                var num1 = double.Parse(Num1.Text);
                var num2 = double.Parse(Num2.Text);
                var total = num1 / num2;
                Total.Text = total.ToString();
                string mensaje = "";

                if (total > 0)
                {
                    mensaje = "Num Positivo++";
                }
                else
                {
                    mensaje = "Num Negativo--";
                }
                DisplayAlert("El resultado es", mensaje, "...");
            }
            else
            {
                DisplayAlert("Error", "no se han puesto los números", "Ok");
            }
        }
    }
}
