using Microsoft.EntityFrameworkCore;
using MVC_02.Models;

namespace MVC_02.Data
{
    public class PerguntasContext : DbContext
    {
        public PerguntasContext(DbContextOptions<PerguntasContext> opt) : base(opt)
        {
        }

        public DbSet<Pergunta> Pergunta {get; set;}
    }
}