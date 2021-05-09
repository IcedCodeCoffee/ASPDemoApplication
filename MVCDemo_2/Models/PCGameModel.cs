using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo_2.Models
{
    public class PCGameModel
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public int ReleaseDate { get; set; }
        public bool MultiPlayer { get; set; }
    }
}