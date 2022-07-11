using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeBaseEvaluation6.Models;

namespace CodeBaseEvaluation6.Data
{
    public class CodeBaseEvaluation6Context : DbContext
    {
        public CodeBaseEvaluation6Context (DbContextOptions<CodeBaseEvaluation6Context> options)
            : base(options)
        {
        }

        public DbSet<CodeBaseEvaluation6.Models.Employee>? Employee { get; set; }
    }
}
