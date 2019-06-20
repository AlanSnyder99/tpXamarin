using BdService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BdService.Controllers
{
    public class AlumnoDbController : ApiController
    {
        // GET: api/AlumnoDb
        public IEnumerable<AlumnoWS> Get()
        {
            MyContext ctx = new MyContext();
            List<Alumno> listaAlumnosDb = new List<Alumno>();
            listaAlumnosDb = ctx.Alumno.ToList();
            List<AlumnoWS> listaAlumnosWs = new List<AlumnoWS>();
            foreach (Alumno alumnoDb in listaAlumnosDb)
            {
                AlumnoWS alumnoWs = new AlumnoWS();
                alumnoWs.IdAlumno = alumnoDb.IdAlumno;
                alumnoWs.Nombre = alumnoDb.Nombre;
                alumnoWs.Apellido = alumnoDb.Apellido;
                alumnoWs.Email = alumnoDb.Email;
                alumnoWs.Password = alumnoDb.Password;
                alumnoWs.PuntosTotales = alumnoDb.PuntosTotales;
                alumnoWs.CantidadRespuestasCorrectas = alumnoDb.CantidadRespuestasCorrectas;
                alumnoWs.CantidadMejorRespuesta = alumnoDb.CantidadMejorRespuesta;
                listaAlumnosWs.Add(alumnoWs);
            }
            return listaAlumnosWs;
        }

        // GET: api/AlumnoDb/5
        public AlumnoWS Get(int id)
        {
            MyContext ctx = new MyContext();
            Alumno alumnoDb = ctx.Alumno.SingleOrDefault(a => a.IdAlumno == id);
            AlumnoWS alumnoWs = new AlumnoWS();
            alumnoWs.IdAlumno = alumnoDb.IdAlumno;
            alumnoWs.Nombre = alumnoDb.Nombre;
            alumnoWs.Apellido = alumnoDb.Apellido;
            alumnoWs.Email = alumnoDb.Email;
            alumnoWs.Password = alumnoDb.Password;
            alumnoWs.PuntosTotales = alumnoDb.PuntosTotales;
            alumnoWs.CantidadRespuestasCorrectas = alumnoDb.CantidadRespuestasCorrectas;
            alumnoWs.CantidadMejorRespuesta = alumnoDb.CantidadMejorRespuesta;
            return alumnoWs;
        }

        // POST: api/AlumnoDb
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/AlumnoDb/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AlumnoDb/5
        public void Delete(int id)
        {
        }
    }
}
