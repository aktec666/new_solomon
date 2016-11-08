﻿using Solomon.TypesExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solomon.Domain.Entities
{
    public class ProblemType
    {
        public ProblemTypes ProblemTypeID { get; set; }
        public string Name { get; set; }
    }
}
