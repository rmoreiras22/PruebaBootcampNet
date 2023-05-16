using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGit
{
    public class Empleado : PersonaEmiliano
    {
        public string legajo {get; set;}

        public DateTime entrada = DateTime.Now;

    }

}
