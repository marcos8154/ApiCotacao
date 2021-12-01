using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class CotacaoPedido
    {
        public CotacaoPedido()
        {

        }

        public CotacaoPedido(Empresa empresa, 
            Fornecedor fornecedor,
            string cnpjTransportadora, 
            DateTime prazoEntregaSolicitado, 
            DateTime? ultimaVisualizacao)
        {
            Id = Guid.NewGuid();
            DataHora = DateTime.Now;
            ItensCotacao = new List<ItemCotacao>();

            EmpresaId = empresa.Id;
            Fornecedor = fornecedor;
            CnpjTransportadora = cnpjTransportadora;
            PrazoEntregaSolicitado = prazoEntregaSolicitado;
            UltimaVisualizacao = ultimaVisualizacao;
        }

        public Guid Id { get; private set; }
        public DateTime DataHora { get; private set; }
        public Guid EmpresaId { get; private set; }
        public Guid FornecedorId { get; private set; }

        public virtual Empresa Empresa { get; private set; }
        public virtual Fornecedor Fornecedor { get; private set; }

        public string CnpjTransportadora { get; private set; }

        public DateTime PrazoEntregaSolicitado { get; private set; }
        public DateTime? UltimaVisualizacao { get; private set; }

        public ICollection<ItemCotacao> ItensCotacao { get; private set; }

        public void InformarTransportadora(string cnpj)
        {
            CnpjTransportadora = cnpj;
        }

        public void Visualizado()
        {
            UltimaVisualizacao = DateTime.Now;
        }
    }
}
