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
        public string ModelName { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string CompanyName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
