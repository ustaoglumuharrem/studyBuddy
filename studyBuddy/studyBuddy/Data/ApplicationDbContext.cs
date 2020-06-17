using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using studyBuddy.Models;

namespace studyBuddy.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Term> Terms { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Pdf> Pdfs { get; set; }

      

        public DbSet<Rate> Rates { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
