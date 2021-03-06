﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTimesheet.Models
{
    public class TimesheetContext : DbContext
    {
        public TimesheetContext(DbContextOptions<TimesheetContext> options)
            : base(options)
        { }

        public DbSet<TimesheetEntry> Entries { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<ProjectDate> ProjectDate { get; set; }
        public DbSet<Developer> Developer { get; set; }

    }
}
