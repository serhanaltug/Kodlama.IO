using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class CustomerDal : EfEntityRepositoryBase<Customer, ReCapContext>, ICustomerDal
    {
        public List<CustomerDetailsDto> GetCustomerDetails(Expression<Func<Customer, bool>> filter = null)
        {
            using (var context = new ReCapContext())
            {
                var result = from customer in filter is null ? context.Customers : context.Customers.Where(filter)
                             join user in context.Users on customer.UserId equals user.Id
                             select new CustomerDetailsDto { CustomerId  = customer.Id, UserId = user.Id, CustomerName = user.FirstName + " " + user.LastName, CompanyName = customer.CompanyName };

                return result.ToList();

            }
        }
    }
}
