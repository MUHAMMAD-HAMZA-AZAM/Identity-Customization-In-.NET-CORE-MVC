using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin_Portal.Models
{
    public class CustomDBContext :DbContext
    {
        public CustomDBContext(DbContextOptions<CustomDBContext> options)
             : base(options)
        {

        }

    }
}
