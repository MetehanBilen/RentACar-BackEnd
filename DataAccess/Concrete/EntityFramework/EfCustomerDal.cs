using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RepCarDBContext>, ICustomerDal
    {

        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (RepCarDBContext context = new RepCarDBContext()) 
            {
                var result = from c in context.Customers
                             join u in context.Users
                             on c.UserId equals u.UserId
                             select new CustomerDetailDto
                             {
                                 CustomerId = c.CustomerId,
                                 UserName = u.UserName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 Password = u.PasswordHash,
                                 CompanyName = c.CompanyName

                             };
                return result.ToList();
           
            }

        }
    }
}
