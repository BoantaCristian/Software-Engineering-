using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WADLAB4.Models
{
    public class Nota
    {
        public long Student { get; set; }

        public string Materie { get; set; }
        
        public int Calificativ { get; set; }
    }
}