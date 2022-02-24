using Cadastro_Pessoa_FS1.Classes;

Console.WriteLine(@$"
==========================
|   Bem Vindo ao Sistema  |
|          PF E PJ        |
==========================
");
Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Magenta;

BarraLoading("CARREGANDO", 1000);

string? opcao;
do
{


    Console.Clear();
    Console.WriteLine(@$"
=================================
| ESCOLHA UMA DAS OPÇÕES ABAIXO |
---------------------------------
|       1 - PF                  |
|       2 - PJ                  |
|                               |
|       0 - SAIR                |             
=================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            PessoaFisica novaPf = new PessoaFisica();
            PessoaFisica metodoPf = new PessoaFisica();

            novaPf.nome = "Saymon";
            novaPf.dataNascimento = "01/01/2000";
            novaPf.cpf = "1234567890";
            novaPf.rendimento = 3000.5f;


            Endereco novoEnd = new Endereco();

            novoEnd.logradouro = "Av Afonso Pena";
            novoEnd.numero = 1010;
            novoEnd.complemento = "Shopping";
            novoEnd.endComercial = true;

            novaPf.endereco = novoEnd;

            bool dataValida = metodoPf.ValidarDataNasc(novaPf.dataNascimento);

            Console.Clear();
            Console.WriteLine(@$"
            Nome: {novaPf.nome}
            Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
            Maior de Idade: {(metodoPf.ValidarDataNasc(novaPf.dataNascimento) ? "Sim" : "Não")}
            Taxa de Imposto a Ser Paga é: {metodoPf.PagarImposto(novaPf.rendimento).ToString("C")}
            ");

            Console.WriteLine($"Aperte Enter para Continuar");
            Console.ReadLine();
            break;
        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();

            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.nome = "Teste pj";
            novaPj.cnpj = "00.000.000/0001-00";
            novaPj.razaosocial = "Teste Razao PJ";
            novaPj.rendimento = 8000.5f;

            novoEndPj.logradouro = "Teste logradouro";
            novoEndPj.numero = 110;
            novoEndPj.complemento = "teste";
            novoEndPj.endComercial = true;

            Console.Clear();
            Console.WriteLine(@$"
            Nome: {novaPj.nome}
            Razão Social: {novaPj.razaosocial}
            CNPJ: {novaPj.cnpj}
            CPNJ Válido: {(metodoPj.ValidarCNPJ(novaPj.cnpj) ? "Sim" : "Não")}
            Taxa de Imposto a Ser Paga é: {metodoPj.PagarImposto(novaPj.rendimento).ToString("C")}
            ");

            Console.WriteLine($"Aperte Enter para Continuar");
            Console.ReadLine();
            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"SAINDO DO SISTEMA");
            BarraLoading("FINALIZANDO", 500);
            break;

        default:
            Console.WriteLine($"Opção Inválida!!!");
            break;
    }
} while (opcao != "0");

static void BarraLoading(string texto, int valor)
{
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.Write($"{texto} ");

            for (var i = 0; i < 10; i++)
            {
                Console.Write(". ");
                Thread.Sleep(valor);
            }

            Console.ResetColor();
}