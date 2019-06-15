using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoInformeXamarin.Modelos
{
    public class Preguntas 
    {
        
        public int Id { get; set; }
        public int idProfesor { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
                return Descripcion;   
        }

    }
}
