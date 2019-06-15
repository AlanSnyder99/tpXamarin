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
        public IEnumerable<Alumno> Get()
        {
            MyContext ctx = new MyContext();
            List<Alumno> listaAlumnos = new List<Alumno>();
            listaAlumnos = ctx.Alumno.ToList();
            return listaAlumnos;
        }

        // GET: api/AlumnoDb/5
        public Alumno Get(int id)
        {
            MyContext ctx = new MyContext();
            Alumno alumno = ctx.Alumno.SingleOrDefault(a => a.IdAlumno == id);
            return alumno;
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
