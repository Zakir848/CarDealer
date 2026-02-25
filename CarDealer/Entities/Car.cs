using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarDealer.Entities
{   
    [Index(nameof(BanCode), IsUnique = true)]
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

        [Required]
        [MaxLength(7)]
        public string? PlateNumber { get; set; }

        [Required]
        [MaxLength(16)]
        public string? BanCode { get; set; }

        public decimal Price { get; set; }

        public int? OwnerId { get; set; }
        public virtual Owner? Owner { get; set; }

        public ICollection<Insurance> Insurances { get; set; } = new List<Insurance>();

    }
}
