using APIRest_Contatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIRest_Contatos.Services
{
    public interface ITelefoneService
    {
        Telefones Create(Telefones pessoa);
        Telefones FindById(long id);
        IList<Telefones> FindAll();
        Telefones Update(Telefones pessoa);
        void Delete(long id);
    }
}
