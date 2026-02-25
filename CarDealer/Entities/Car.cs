using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarDealer.Entities
{       
    [Index(nameof(PlateNumber), IsUnique = true)]
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string? Brand { get; set; }

        [Required]
        [MaxLength(150)]
        public string? Model { get; set; }

        [Range(1900,2026)]
        public int ProductionYear { get; set; }

        public double EngineLitr { get; set; }

        [Required]
        [MaxLength(7)]
        public string? PlateNumber { get; set; }        

        public decimal Price { get; set; }

        public TechnicalPassport? TechnicalPassport { get; set; }

    }
}
