﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class myContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
       
    }
}
