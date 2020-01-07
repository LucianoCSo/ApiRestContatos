using APIRest_Contatos.Models;
using APIRest_Contatos.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace APIRest_Contatos.Services.Implementation
{
    public class PessoaService : IPessoaService
    {
        private volatile int Cont;
        private SqlContext _context;

        public PessoaService(SqlContext context)
        {
            _context = context;
        }
        public Contato Create(Contato pessoa)
        {
            try
            {
                _context.Add(pessoa);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return pessoa;
        }

        public void Delete(long id)
        {
            var result = _context.Contatos.SingleOrDefault(x => x.Id == id);
            try
            {
                if (result != null)
                {
                    _context.Contatos.Remove(result);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Contato> FindAll()
        {
            try
            {
                return _context.Contatos.ToArray();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Contato FindById(long id)
        {
            return _context.Contatos.SingleOrDefault(x => x.Id == id);
        }

        public Contato Update(Contato pessoa)
        {
            if (!Exist(pessoa.Id)) return new Contato();
            var result = _context.Contatos.SingleOrDefault(x => x.Id.Equals(pessoa.Id));
            try
            {
                _context.Entry(result).CurrentValues.SetValues(pessoa);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return pessoa;
        }

        private bool Exist(int? id)
        {
            return _context.Contatos.Any(x => x.Id.Equals(id));
        }
    }
}
