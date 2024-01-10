using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CustomerDetailDto :IDto
    {
        public int CustomerId { get; set; }
        public string UserName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
        public byte[] Password { get; set; }

        public string CompanyName { get; set; }
    }
}
