﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectDeployment1.Models;

namespace ProjectDeployment1.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base (options)
        {

        }
        public DbSet<Registration> Registration { get; set; }
    }
}
