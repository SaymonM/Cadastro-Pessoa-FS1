using Cadastro_Pessoa_FS1.Interfaces;

namespace Cadastro_Pessoa_FS1.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string ?cnpj { get; set; }

        public string ?razaosocial { get; set; }

        
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCNPJ(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}