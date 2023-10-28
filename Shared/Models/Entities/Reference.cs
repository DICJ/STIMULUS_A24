﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STIMULUS.Shared.Models.Entities
{
    public class Reference
    {
        public int ReferenceId { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Url { get; set; }

        public string? Description { get; set; }
    }
}
