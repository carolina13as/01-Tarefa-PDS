using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa01_PDS
{
    public class Empresa
    {
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string SituacaoCadastral { get; set; }
        public string Telefone { get; set; }
        public string CapitalSocial { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Estado { get; set; }
        public string Tipo { get; set; }
        public string PorteEmpresa { get; set; }
        public string NaturezaJuridica { get; set; }
        public string NomeProprietario { get; set; }
        public string CPFProprietario { get; set; }
        public string RegimeTributario { get; set; }
        public string DataInicio { get; set; }

        public Empresa(string cNPJ, string razaoSocial, string nomeFantasia, string situacaoCadastral, string telefone, string capitalSocial, string rua, string numero, string bairro, string complemento, string estado, string tipo, string porteEmpresa, string naturezaJuridica, string nomeProprietario, string cPFProprietario, string regimeTributario, string dataInicio)
        {
            CNPJ = cNPJ;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            SituacaoCadastral = situacaoCadastral;
            Telefone = telefone;
            CapitalSocial = capitalSocial;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Complemento = complemento;
            Estado = estado;
            Tipo = tipo;
            PorteEmpresa = porteEmpresa;
            NaturezaJuridica = naturezaJuridica;
            NomeProprietario = nomeProprietario;
            CPFProprietario = cPFProprietario;
            RegimeTributario = regimeTributario;
            DataInicio = dataInicio;
        }


       
    }
}
