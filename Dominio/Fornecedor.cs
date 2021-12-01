using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Fornecedor
    {
        public Guid Id { get; private set; }
        public string CnpjCpf { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string Endereco { get; private set; }
        public string CEP { get; private set; }
        public string Bairro { get; private set; }

        public ICollection<Empresa> Empresas { get; private set; }

        public Fornecedor()
        {

        }

        public Fornecedor(Empresa empresa,
            string cnpjCpf, 
            string nome, 
            string email, 
            string telefone, 
            string endereco,
            string cEP,
            string bairro)
        {
            CnpjCpf = cnpjCpf;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            CEP = cEP;
            Bairro = bairro;

            AdicionaEmpresa(empresa);
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

        internal void AdicionaEmpresa(Empresa empresa)
        {
            Empresas.Add(empresa);
        }
    }
}
