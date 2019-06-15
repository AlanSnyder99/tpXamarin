using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoInformeXamarin.Modelos;
using TrabajoInformeXamarin.Servicios;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace TrabajoInformeXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndexAlumno : ContentPage
    {
        public IList<Preguntas> listaPreguntas { get;  private set; }

        public IndexAlumno()
        {
            InitializeComponent();

            listaPreguntas = new List<Preguntas>();
            listaPreguntas.Add(new Preguntas { Id = 1, Descripcion = "aaaa?", idProfesor = 1 });
            listaPreguntas.Add(new Preguntas { Id = 2, Descripcion = "bbbb?", idProfesor = 2 });

            BindingContext = this;

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