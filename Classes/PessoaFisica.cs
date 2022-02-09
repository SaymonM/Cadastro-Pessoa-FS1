using Cadastro_Pessoa_FS1.Interfaces;

namespace Cadastro_Pessoa_FS1.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {

        public string ?cpf { get; set;}
        public DateTime ?dataNascimento { get; set; }


        public bool ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}