﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public int MId { get; set; }

        [DisplayName("Descripción")]
        public string MDescripcion { get; set; }

        public override string ToString()
        {
            return MDescripcion;
        }
    }
}
