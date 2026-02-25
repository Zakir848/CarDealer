using CarDealer.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarDealer.Entities
{
    [Index(nameof(BanCode), IsUnique = true)]
    public class TechnicalPassport
    {       

        [Key]
        public int CarId { get; set; }
        
        [Required]
        [MaxLength(16)]
        public string? SeriaNumber { get; set; }

        [Required]
        [MaxLength(16)]
        public string? BanCode { get; set; }
        public Car? Car { get; set; }
    }
}
