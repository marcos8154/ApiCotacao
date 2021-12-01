using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ItemCotacao
    {
        public Guid Id { get; private set; }
        public Guid CotacaoId { get; private set; }
        public Guid ProdutoId { get; private set; }

        public virtual CotacaoPedido Cotacao { get; private set; }
        public virtual Produto Produto { get; private set; }

        public double QuantidadeSolicitada { get; private set; }
        public double QuantidadeAtendida { get; private set; }
        public decimal Preco { get; private set; }
        public string CondicaoPagamento { get; private set; }
        public int PrazoEntregaPrevistoDias { get; private set; }

        public void InformarCotacao(double quantAtendida, decimal preco, string condicaoPagamento)
        {
            QuantidadeAtendida = quantAtendida;
            Preco = preco;
            CondicaoPagamento = condicaoPagamento;
        }

        public ItemCotacao()
        {
                
        }

        public ItemCotacao(
            CotacaoPedido cotacao,
            Produto produto,
            double quantidadeSolicitada,
            int prazoEntregaPrevistoDias)
        {
            Id = Guid.NewGuid();
            CotacaoId = cotacao.Id;
            ProdutoId = produto.Id;

            QuantidadeSolicitada = quantidadeSolicitada;
            PrazoEntregaPrevistoDias = prazoEntregaPrevistoDias;
        }
    }
}
