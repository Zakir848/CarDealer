using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarDealer.Entities
{
    public class Insurance
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int CarId { get; set; }

        public virtual Car? Car { get; set; } = null!;
    }
}
