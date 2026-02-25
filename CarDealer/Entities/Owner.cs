using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarDealer.Entities
{
    [Index(nameof(Fincode), IsUnique = true)]
    public class Owner
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string? FullName { get; set; }

        [Required]
        [MaxLength(7)]
        public string? Fincode { get; set; }

        public int CarId { get; set; }
        public ICollection<Car>? Cars { get; set; } = new List<Car>();
    }
}
