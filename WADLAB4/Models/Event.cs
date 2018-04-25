using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WADLAB4.Models
{
    public class Event
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public string Location { get; set; }

        public int Category { get; set; }
    }
}