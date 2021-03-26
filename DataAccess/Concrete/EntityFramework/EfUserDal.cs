using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<UserDetailDto> GetUserDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {

                var result = from u in context.Users
                             join c in context.Customers
                             on u.UserId equals c.Id
                             select new UserDetailDto {CompanyName=c.CompanyName, Email = u.Email, FirstName=u.FirstName, LastName=u.LastName, Password= u.Password };

                return result.ToList();
            }
        }
    }
}
