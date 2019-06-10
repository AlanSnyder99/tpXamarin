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
            Usuario usuario = new Usuario(contrasena.Text, email.Text);
          
            if (usuario.ValidacionLogin())
            {
                DisplayAlert("Login", "Inicio Exitoso", "Oka");
                this.Navigation.PushModalAsync(new IndexAlumno());
            }
            else
            {
                DisplayAlert("Login", "Error de Login, Contraseña o Email invalidos", "Oka");
            }

        }

        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Preguntas selectedItem = e.SelectedItem as Preguntas;
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Preguntas tappedItem = e.Item as Preguntas;
        }

    }
}
