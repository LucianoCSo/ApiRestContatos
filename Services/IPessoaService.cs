using APIRest_Contatos.Models;
using System.Collections.Generic;

namespace APIRest_Contatos.Services
{
    public interface IPessoaService
    {
        Contato Create(Contato pessoa);
        Contato FindById(long id);
        IList<Contato> FindAll();
        Contato Update(Contato pessoa);
        void Delete(long id);
    }
}
