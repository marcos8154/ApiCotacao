using Dapper;
using Dominio;
using IoCdotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Impl
{
    internal sealed class EmpresaRepositorioImpl : IEmpresaRepositorio
    {
        private readonly IDatabase db;

        public EmpresaRepositorioImpl()
        {
            db = IoC.Resolve<IDatabase>();
        }

        public Empresa Obter(Guid id)
        {
            return db.Empresas.Find(id);
        }

        public void Inserir(Empresa e)
        {
            db.Empresas.Add(e);
            db.SalvarMudancas();
        }

        public void Atualizar(Empresa e)
        {
            db.Empresas.Update(e);
            db.SalvarMudancas();
        }

        public void Remover(Empresa e)
        {
            e.Excluir();
            Atualizar(e);
        }

        public IReadOnlyCollection<Empresa> BuscarLinq(Expression<Func<Empresa, bool>> filtro)
        {
            return db.Empresas
                .Where(e => e.Excluido == false)
                .Where(filtro)
                .ToList()
                .AsReadOnly();
        }

        public IReadOnlyCollection<Empresa> BuscarSql(string sql, object parametro)
        {
            return db.Connection()
                .Query<Empresa>(sql, parametro)
                .ToList()
                .AsReadOnly();
        }
    }
}
