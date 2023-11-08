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
        //New
        private void BotonPOTENCIA(Object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Num1.Text) && !string.IsNullOrEmpty(Num2.Text))
            {
                var num1 = double.Parse(Num1.Text); //Número que voy a multiplicar
                var num2 = double.Parse(Num2.Text); //Número al cual voy a elevar el número de arriba
                var total = Math.Pow(num1,num2);
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
        private void BotonRAIZCUADRADA(Object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Num1.Text) || !string.IsNullOrEmpty(Num2.Text))
            {
                var num1 = double.Parse(Num1.Text);
               // var num2 = double.Parse(Num2.Text); Comento esta línea porque solo saco la raíz del primer número. 
                var total = Math.Sqrt(num1);       
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
        private void BotonPORCENTAJE(Object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Num1.Text) && !string.IsNullOrEmpty(Num2.Text))
            {
                var num1 = double.Parse(Num1.Text); //el % que quiero sacar
                var num2 = double.Parse(Num2.Text); //el total del número al que quiero sacarle el %
                var total = (num1 * num2) / 100;
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
        private void BotonClean(Object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Num1.Text) && !string.IsNullOrEmpty(Num2.Text))
            {
                Num1.Text = "";
                Num2.Text = "";
                Total.Text = "";
            }
            //else
            //{
            //    DisplayAlert("Error", "no se han puesto los números", "Ok");
            //}
        }
    }
}
