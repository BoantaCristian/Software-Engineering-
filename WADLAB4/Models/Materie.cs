using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WADLAB4.Models
{
    public class Materie
    {
        public int id { get; set; }

        public string Nume { get; set; }

        public int TotalOre { get; set; }

        public int Credite { get; set; }

        public string Profesor { get; set; }

        public int IDSpec { get; set; }
        
        public int An { get; set; }

        public int Sem { get; set; }
    }
}