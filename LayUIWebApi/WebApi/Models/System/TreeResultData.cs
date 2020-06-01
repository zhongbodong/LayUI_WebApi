using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models.System
{
    public class TreeResultData
    {
        public Guid id { get; set; }

        public string title { get; set; }

        public string href { get; set; }

        //public bool checked { get; set; }

        public bool disabled { get; set; }
        public List<TreeResultData> children { get; set; }
    }
}