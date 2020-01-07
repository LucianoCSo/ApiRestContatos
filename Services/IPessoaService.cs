using APIRest_Contatos.Models;
using System.Collections.Generic;

namespace APIRest_Contatos.Services
{
    public interface IPessoaService
    {
        Pessoa Create(Pessoa pessoa);
        Pessoa FindById(long id);
        IList<Pessoa> FindAll();
        Pessoa Update(Pessoa pessoa);
        void Delete(long id);
    }
}
