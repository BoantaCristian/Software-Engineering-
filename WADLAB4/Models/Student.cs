using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WADLAB4.Models
{
    public class Student
    {
        public int ID { get; set; }

        public long CNP { get; set; }

        public string Nume { get; set; }

        public string Prenume { get; set; }

        public int An { get; set; }

        public int Semestru { get; set; }

        public string Specializare { get; set; }

        public int Credite { get; set; }
    }
}