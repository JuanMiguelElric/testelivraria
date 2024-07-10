using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string? titulo { get; set; }
        public string? autor {  get; set; }
        public DateTime? lancamento { get; set; }

     
    }
}
