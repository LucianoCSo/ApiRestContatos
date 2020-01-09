using System.Collections.Generic;

namespace APIRest_Contatos.Models
{
    public class Telefones
    {
        public int? id { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public int Id_Contato { get; set; }
    }
}
