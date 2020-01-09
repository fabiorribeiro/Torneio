﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Torneio.Models
{
    public class Torneio
    {
        public int id { get; set; }
        public string nome { get; set; }
        public virtual ICollection<Jogo> jogos { get; set; }
    }
}