using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Iusico_Laura_Lab6.Models;

namespace Iusico_Laura_Lab6.Data
{
    public class Iusico_Laura_Lab6Context : DbContext
    {
        public Iusico_Laura_Lab6Context (DbContextOptions<Iusico_Laura_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Iusico_Laura_Lab6.Models.Book> Book { get; set; }
    }
}
