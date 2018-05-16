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

        public long Profesor { get; set; }
    }
}