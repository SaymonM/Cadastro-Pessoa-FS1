using System;
using Cadastro_Pessoa_FS1.Interfaces;

namespace Cadastro_Pessoa_FS1.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {

        public string ?cpf { get; set;}
        public string ?dataNascimento { get; set; }


        public bool ValidarDataNasc(string dataNasc)
        {

            DateTime dataConvertida;
            if (DateTime.TryParse(dataNasc, out dataConvertida))
            {
                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                if(anos >= 18)
                {
                    return true;
                } 
                    return false;
            }
            return false;
        }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}