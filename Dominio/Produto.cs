using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Produto
    {
        public Guid Id { get; private set; }
        public Guid EmpresaId { get; private set; }
        public virtual Empresa Empresa { get; private set; }

        public Produto()
        {

        }

        public Produto(Empresa empresa, 
            string codigoSistema, 
            string nome,
            string codigoBarras,
            string unidade,
            double pesoBruto = 0, 
            double pesoLiquido = 0,
            string numeroLote = null,
            string numeroSerie = null,
            string fabricante = null, 
            string marca = null, 
            string ano = null, 
            string modelo = null,
            string geracao = null)
        {
            Id = Guid.NewGuid();
            EmpresaId = empresa.Id;
            CodigoSistema = codigoSistema;
            Nome = nome;
            CodigoBarras = codigoBarras;
            Unidade = unidade;
            AtualizaInfo(pesoBruto, 
                pesoLiquido, 
                numeroLote, 
                numeroSerie, 
                fabricante, 
                marca, 
                ano, 
                modelo, 
                geracao);
        }

        public void AtualizaInfo(double pesoBruto, 
            double pesoLiquido, 
            string numeroLote, 
            string numeroSerie, 
            string fabricante, 
            string marca,
            string ano,
            string modelo, 
            string geracao)
        {
            PesoBruto = pesoBruto;
            PesoLiquido = pesoLiquido;
            NumeroLote = numeroLote;
            NumeroSerie = numeroSerie;
            Fabricante = fabricante;
            Marca = marca;
            Ano = ano;
            Modelo = modelo;
            Geracao = geracao;
        }

        public string CodigoSistema { get; private set; }
        public string Nome { get; private set; }
        public string CodigoBarras { get; private set; }
        public string Unidade { get; private set; }
        public double PesoBruto { get; private set; }
        public double PesoLiquido { get; private set; }
        public string NumeroLote { get; private set; }
        public string NumeroSerie { get; private set; }
        public string Fabricante { get; private set; }
        public string Marca { get; private set; }
        public string Ano { get; private set; }
        public string Modelo { get; private set; }
        public string Geracao { get; private set; }
        public bool Excluido { get; private set; }
        public DateTime? DataExclusao { get; private set; }


        public void Excluir()
        {
            Excluido = true;
            DataExclusao = DateTime.Now;
        }
    }
}
