﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProMemContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Member> Members { get; set; }

        //fahim is good fboy
        // tahmid is a sick man 
        // fahim vai 
        //okok
    }
}
