using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssignmentDay6.Model;

namespace AssignmentDay6.Data
{
    public class AssignmentDay6Context : DbContext
    {
        public AssignmentDay6Context (DbContextOptions<AssignmentDay6Context> options)
            : base(options)
        {
        }

        public DbSet<AssignmentDay6.Model.Movie> Movie { get; set; } = default!;
    }
}
