using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class RentalDetailDto :IDto
    {
        public int Id { get; set; }

        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }


        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }


        public string RentDate { get; set; }
        public string ReturnDate { get; set; }
    }
}
