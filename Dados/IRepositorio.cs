using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    /*
     * Inteface básica para definição
     * de funções comuns de persistencia
     * do estado das entidades
     * 
     * A interface IRepositorio requer um tipo
     * de classe base na assinatura.
     * Na implementação, essa "classe base" é a
     * propria entidade
     * */
    public interface IRepositorio<TEntidade>
    {    
        public TEntidade Obter(Guid id);

        public void Inserir(TEntidade e);
        public void Atualizar(TEntidade e);
        public void Remover(TEntidade e);
    
        public IReadOnlyCollection<TEntidade> BuscarLinq(Expression<Func<TEntidade, bool>> filtro);
        public IReadOnlyCollection<TEntidade> BuscarSql(string sql, object parametro);
    }
}
