using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace helloDotNetAPI.Models
{
    public class Monkey
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Size { get; set; }
        public string Location { get; set; }

        public string self
        {
            get { return string.Format(CultureInfo.CurrentCulture, "api/monkey/{0}", Id); }
        }
    }
}