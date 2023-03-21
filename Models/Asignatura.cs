using System;

namespace platzi_asp_net_core.Models
{
    public class Asignatura:ObjetoEscuelaBase
    {
        public string CursoId { get; set; }


        public Curso curso { get; set; }

        public List<Evaluación> evaluaciones { get; set; }
    }
}