using QBS_CORE_WEBAPI.Data;
using QBS_CORE_WEBAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QBS_CORE_WEBAPI.Data
{
    public static class DbInitializer
    {
        public static void Initialize(QbsContext context)
        {
            context.Database.EnsureCreated();           

            var AppUser = new ApplicationUsers[]
            {
                    new ApplicationUsers{LoginId="Harendra",Password="1234",FullName="Harendra Kumar",Email="harendra.kumar@gmail.com",Mobile="9958271070"}
            };
            foreach (ApplicationUsers s in AppUser)
            {
                context.ApplicationUsers.Add(s);
            }
            context.SaveChanges();


           
        }
    }
}
