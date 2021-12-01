using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empresa
    {
        public Guid Id { get; private set; }
        public string CnpjCpf { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string Endereco { get; private set; }
        public string CEP { get; private set; }
        public string Bairro { get; private set; }

        public List<Produto> Produtos { get; private set; }
        public ICollection<Fornecedor> Fornecedores { get; private set; }
        public bool Excluido { get; private set; }
        public DateTime? DataExclusao { get; private set; }

        public Empresa()
        {

        }

        public Empresa(string cnpjCpf, 
            string nome, 
            string email, 
            string telefone, 
            string endereco,
            string cep, 
            string bairro)
        {
            Id = Guid.NewGuid();
            Produtos = new List<Produto>();
            Fornecedores = new List<Fornecedor>();

            CnpjCpf = cnpjCpf;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            CEP = cep;
            Bairro = bairro;
        }

        public void Excluir()
        {
            Excluido = true;
            DataExclusao = DateTime.Now;
        }

        public void AdicionarFornecedor(Fornecedor fornecedor)
        {
            fornecedor.AdicionaEmpresa(this);
            Fornecedores.Add(fornecedor);
        }

        public void AtualizarContato(string telefone, string email)
        {
            Telefone = telefone;
            Email = email;
        }

        public void AtualizarEndereco(string endereco,
            string cep,
            string bairro)
        {
            Endereco = endereco;
            CEP = cep;
            Bairro = bairro;
        }
    }
}
