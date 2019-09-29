using MVC_02.Data;
using System.Collections.Generic;
using MVC_02.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MVC_02.Services
{
    public class PerguntasService
    {
        private readonly PerguntasContext _context;

        public PerguntasService(PerguntasContext c)
        {
            _context = c;
        }

        public async Task<List<Pergunta>> FindAllAsync()
        {
            return await _context.Pergunta.ToListAsync();
        }
    }
}