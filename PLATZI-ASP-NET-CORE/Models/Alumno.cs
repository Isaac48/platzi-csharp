using System;
using System.Collections.Generic;

namespace PLATZI_ASP_NET_CORE.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluación> Evaluaciones { get; set; } = new List<Evaluación>();
    }
}