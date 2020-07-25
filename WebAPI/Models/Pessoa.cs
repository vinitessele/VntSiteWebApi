using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Pessoa
    {
        private ILog Logger = LogManager.GetLogger(typeof(Pessoa));

        public List<DtoPessoa> getlistapessoas()
        {
            try
            {
                Context db = new Context();
                return db.pessoas.ToList();
            }
            catch (Exception ex)
            {
                Logger.Error("listapessoas", ex.InnerException);
                throw ex;
            }
        }
        public DtoPessoa getPessoaId(int id)
        {
            try
            {
                Context db = new Context();
                return db.pessoas.Where(p => p.id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Logger.Error("getPessoaId", ex.InnerException);
                throw ex;
            }
        }
        public DtoPessoa getPessoaCPF(string cpf)
        {
            try
            {
                Context db = new Context();
                return db.pessoas.Where(p => p.cpf == cpf).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Logger.Error("getPessoaCPF", ex.InnerException);
                throw ex;
            }
        }

        public List<DtoPessoa> getPessoaTp(int tipoPessoa)
        {
            try
            {
                Context db = new Context();
                return db.pessoas.Where(p => p.tp_login == tipoPessoa).ToList();
            }
            catch (Exception ex)
            {
                Logger.Error("getPessoaTp", ex.InnerException);
                throw ex;
            }
        }
        public DtoPessoa getPessoaEmail(string email)
        {
            try
            {
                Context db = new Context();
                return db.pessoas.Where(p => p.email == email).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Logger.Error("getPessoaEmail", ex.InnerException);
                throw ex;
            }
        }
        public void Atualizar(int id, DtoPessoa pessoa)
        {
            try
            {
                Context db = new Context();
                DtoPessoa x = db.pessoas.Where(p => p.id == id).FirstOrDefault();
                x.nome = pessoa.nome;
                x.endereco = pessoa.endereco;
                x.celular = pessoa.celular;
                x.cep = pessoa.cep;
                x.cidade = pessoa.cidade;
                x.uf = pessoa.uf;
                x.dt_nascimento = pessoa.dt_nascimento;
                x.email = pessoa.email;
                x.complemento = pessoa.complemento;
                x.domingo = pessoa.domingo;
                x.domingohoras = pessoa.domingohoras;
                x.segunda = pessoa.segunda;
                x.segundahoras = pessoa.segundahoras;
                x.terca = pessoa.terca;
                x.tercahoras = pessoa.tercahoras;
                x.quarta = pessoa.quarta;
                x.quartahoras = pessoa.quartahoras;
                x.quinta = pessoa.quinta;
                x.quintahoras = pessoa.quintahoras;
                x.sexta = pessoa.sexta;
                x.sextahoras = pessoa.sextahoras;
                x.sabado = pessoa.sabado;
                x.sabadohoras = pessoa.sabadohoras;
                x.observacao = pessoa.observacao;
                x.valor_hora = pessoa.valor_hora;
                x.avaliacao = pessoa.avaliacao;
                x.especialidade = pessoa.especialidade;

                db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Logger.Error("Atualizar", ex.InnerException);
                throw ex;
            }
        }

        public void Gravar(DtoPessoa pessoa)
        {
            try
            {
                Context db = new Context();
                db.pessoas.Add(pessoa);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Logger.Error("GarvarPessoa", ex.InnerException);
                throw ex;
            }
        }

        internal void Deletar(int id)
        {
            Context db = new Context();
            var x = db.pessoas.Where(p => p.id == id).FirstOrDefault();
            db.pessoas.Remove(x);
            db.SaveChangesAsync();
        }
    }
}