using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TrabajoInformeXamarin.Modelos;

namespace TrabajoInformeXamarin
{

    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void ProcedimientoDeLogin(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(email.Text, contrasena.Text);
          
            if (usuario.ValidacionLogin())
            {
                DisplayAlert("Login", "Inicio Exitoso", "Oka");
                this.Navigation.PushModalAsync(new Index());
            }
            else
            {
                DisplayAlert("Login", "Error de Login, Contraseña o Email invalidos", "Oka");
            }

        }

    }

    }

