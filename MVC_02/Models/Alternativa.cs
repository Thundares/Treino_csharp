namespace MVC_02.Models
{
    public class Alternativa
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public bool Correto { get; set; }

        public Alternativa()
        {
            Correto = false;
        }   
    }
}