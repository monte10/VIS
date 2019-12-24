using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO.Tridy;

namespace WebApp.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Tym> Tymy { get; set; }

        public IEnumerable<Hrac> Kanada { get; set; }

        public IEnumerable<Tym> Goly { get; set; }

        public IEnumerable<Hrac> Tresty { get; set; }
    }
}