using Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public interface IDatabase
    {
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<CotacaoPedido> CotacoesPedidos { get; set; }
        public DbSet<ItemCotacao> ItensCotacao { get; set; }

        public void SalvarMudancas();

        public IDbConnection Connection();
    }
}
