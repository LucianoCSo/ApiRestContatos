using APIRest_Contatos.Models;
using System;
using System.Collections.Generic;
using System.Threading;

namespace APIRest_Contatos.Services.Implementation
{
    public class PessoaService : IPessoaService
    {
        private volatile int Cont;

        public Pessoa Create(Pessoa pessoa)
        {
            return pessoa;
        }

        public void Delete(long id)
        {
        }

        public IList<Pessoa> FindAll()
        {
            IList<Pessoa> pessoas = new List<Pessoa>();
            for (int i = 0; i < 8; i++)
            {
                Pessoa person = MockPessoa(i);
                pessoas.Add(person);
            }
            return pessoas;
        }

        private Pessoa MockPessoa(int i)
        {
            return new Pessoa
            {
                Id = IncrementeAndGet(),
                Nome = "Luciano",
                Endereco = "Avenida Poebla",
                Bairro = "Jose Walter",
                Cidade = "Fortaleza",
                Estado = "CE",
                Cep = "60760-180",
                Status = 1
            };
        }

        private long IncrementeAndGet()
        {
            return Interlocked.Increment(ref Cont);
        }

        public Pessoa FindById(long id)
        {
            return new Pessoa
            {
                Id = IncrementeAndGet(),
                Nome = "Luciano",
                Endereco = "Avenida Poebla",
                Bairro = "Jose Walter",
                Cidade = "Fortaleza",
                Estado = "CE",
                Cep = "60760-180",
                Status = 1
            };
        }

        public Pessoa Update(Pessoa pessoa)
        {
            return pessoa;
        }
    }
}
