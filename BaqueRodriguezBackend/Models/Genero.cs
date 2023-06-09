﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaqueRodriguezBackend.Models
{

    public class Genero
    {

        public int id { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public String nombre { get; set; }
        public Boolean estado { get; set; }
    }
}
