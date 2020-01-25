using APIRest_Contatos.Models;
using APIRest_Contatos.Models.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIRest_Contatos.Services.Implementation
{
    public class TelefoneService : ITelefoneService
    {
        private SqlContext _context;

        public TelefoneService(SqlContext context)
        {
            _context = context;
        }
        public Telefones Create(Telefones telefone)
        {
            try
            {
                _context.Add(telefone);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return telefone;
        }

        public void Delete(long id)
        {
            var result = _context.Telefones.SingleOrDefault(x => x.id == id);
            try
            {
                if(result != null)
                {
                    _context.Telefones.Remove(result);
                    _context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public IList<Telefones> FindAll()
        {
            try
            {
                return _context.Telefones.Include(x => x.Contato).ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Telefones FindById(long id)
        {
            return _context.Telefones.SingleOrDefault(x => x.id == id);
        }

        public Telefones Update(Telefones telefone)
        {
            if (!Existe(telefone.id)) return new Telefones();
            var result = _context.Telefones.SingleOrDefault(x => x.id == telefone.id);
            try
            {
                _context.Entry(result).CurrentValues.SetValues(telefone);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return telefone;
        }

        public bool Existe(int? id)
        {
            return _context.Telefones.Any(x => x.id == id);
        }
    }
}
