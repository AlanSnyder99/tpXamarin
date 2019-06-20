using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoInformeXamarin.Modelos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace TrabajoInformeXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TablaPosiciones : ContentPage
    {
        public TablaPosiciones()
        {
            InitializeComponent();
        }

        private async void BtnCallWS_Click(object sender, EventArgs e)
        {
            WSClient client = new WSClient();
            var result = await client.Get<WSResult>("http://localhost:49275/api/alumnodb/");
            string h = string.Empty;

            if (result != null)
            {
                IList<WSResult> listaPosiciones = new List<WSResult>();
                IList<WSResult> listaPosicionesVista = new List<WSResult>();
                listaPosiciones.Add(result);
                foreach (WSResult item in listaPosiciones)
                {
                    WSResult wsResult = new WSResult();
                    wsResult.Nombre = item.Nombre;
                    wsResult.Email = item.Email;
                    wsResult.PuntosTotales = item.PuntosTotales;
                    listaPosicionesVista.Add(wsResult);
                    BindingContext = this;
                }

            }
        }
    }
}