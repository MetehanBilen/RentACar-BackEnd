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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RepCarDBContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails() 
        {
            using (RepCarDBContext context = new RepCarDBContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cl in context.Colors
                             on c.ColorId equals cl.ColorId

                             join cs in context.Customers
                             on r.CustomerId equals cs.CustomerId
                             join u in context.Users
                             on cs.UserId equals u.UserId

                             select new RentalDetailDto
                             {
                                 Id = r.Id,

                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,  

                                 UserName = u.UserName,
                                 LastName = u.LastName,
                                 Email = u.Email,

                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate


                             };
                return result.ToList();






            }
        }
       
        
    }
}
