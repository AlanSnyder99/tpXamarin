using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoInformeXamarin.Modelos
{
    public class Usuario
    {

        public int Id { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }

        public Usuario()
        {

        }

        public Usuario(string Email, string Contrasena)
        {
            this.Email = Email;
            this.Contrasena = Contrasena;
        }

        public Boolean ValidacionLogin()
        {
            Usuario usuarioPredetermiando = new Usuario();
            usuarioPredetermiando.Contrasena = "1234";
            usuarioPredetermiando.Email = "prueba@prueba.com";

            if (!this.Email.Equals("") && !this.Contrasena.Equals(""))
            {
                if (this.Email == usuarioPredetermiando.Email && this.Contrasena == usuarioPredetermiando.Contrasena)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            else
            {
                return false;
            }

        }
    }

}

