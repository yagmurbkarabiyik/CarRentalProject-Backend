using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
   public class RentalDetailDto : IDto
    {
        public int RentalId { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal DailyPrice { get; set; }

    }
}
