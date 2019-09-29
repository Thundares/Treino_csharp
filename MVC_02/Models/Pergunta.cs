using System.Collections.Generic;

namespace MVC_02.Models
{
    public class Pergunta
    {
        public int Id { get; set; }
        public string Perg { get; set; }
        public int Eliminacao { get; set; }
        public int Acerto { get; set; }
        public List<Alternativa> Alternativas { get; set; }

        public Pergunta()
        {
            Eliminacao = 0;
            Acerto = 0;
            Alternativas = new List<Alternativa>();
        }

        public string Mostrar()
        {
            return Perg;
        }

        public void AddAlternativa(Alternativa obj)
        {
            Alternativas.Add(obj);
        }
    }
}