using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF4
{
    public class AlumnosRepositorio
    {
        AlumnoDBContext alumnoDBContext = new AlumnoDBContext();

        public List<Alumno> GetAlumnos()
        {
            return alumnoDBContext.Alumnos.ToList();
        }

        public void insertarAlumno(Alumno alumno)
        {
            alumnoDBContext.Alumnos.Add(alumno);
            alumnoDBContext.SaveChanges();
        }

        public void actualizarAlumno(Alumno alumno)
        {
            Alumno alumnoAactualizar = alumnoDBContext.Alumnos.FirstOrDefault(x => x.ID == alumno.ID);
            alumnoAactualizar.Nombre = alumno.Nombre;
            alumnoAactualizar.Apellidos = alumno.Apellidos;
            alumnoAactualizar.Genero = alumno.Genero;
            alumnoAactualizar.Edad = alumno.Edad;
            alumnoDBContext.SaveChanges();
        }

        public void borrarAlumno(Alumno alumno)
        {
                Alumno alumnoAborrar = alumnoDBContext.Alumnos.FirstOrDefault(t => t.ID == alumno.ID);
                alumnoDBContext.Alumnos.Remove(alumnoAborrar);
                alumnoDBContext.SaveChanges();      
        }
    }
}