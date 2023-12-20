using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public  class Cursos
    {
        public int idCursos {  get; set; }
        public string nombreCurso {  get; set; }

        public Cursos()
        {
        }

        public Cursos(int idCursos, string nombreCurso)
        {
            this.idCursos = idCursos;
            this.nombreCurso = nombreCurso;
        }
    }
}
