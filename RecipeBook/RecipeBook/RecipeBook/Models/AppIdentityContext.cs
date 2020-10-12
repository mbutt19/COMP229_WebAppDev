﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    public class AppIdentityContext : IdentityDbContext<IdentityUser> 
    {
        public AppIdentityContext(DbContextOptions<AppIdentityContext> options)
            : base(options){ }
    }
}
