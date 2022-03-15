using Cadastro_Pessoa_FS1.Classes;

Console.WriteLine(@$"
==========================
|   Bem Vindo ao Sistema  |
|          PF E PJ        |
==========================
");
Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Magenta;

BarraLoading("CARREGANDO", 500);

List<PessoaFisica> listaPf = new List<PessoaFisica>();
List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

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
            
            PessoaFisica metodoPf = new PessoaFisica();
            
            
            string opcaoPf;
            do
            {
                    Console.Clear();
                    Console.WriteLine(@$"
                ======================================
                | ESCOLHA UMA DAS OPÇÕES ABAIXO      |
                --------------------------------------
                |       1 - Cadastrar PF             |
                |       2 - Mostrar PF               |
                |                                    |
                |       0 - Retornar ao Menu Inicial |             
                ======================================
                ");

                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1":
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEnd = new Endereco();

                        Console.WriteLine($"Digite o NOME da Pessoa Física que deseja cadastrar");
                        novaPf.nome = Console.ReadLine();

                        bool dataValida;
                        do
                        {
                            Console.WriteLine($"Digite a DATA DE NASCIMENTO da Pessoa Física que deseja cadastrar");
                            string? dataNasc = Console.ReadLine();

                            dataValida = metodoPf.ValidarDataNasc(dataNasc);
                        if (metodoPf.ValidarDataNasc(dataNasc))
                        {
                            novaPf.dataNascimento = dataNasc;
                        } else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"DATA INVÁLIDA!!!");
                            Console.ResetColor();
                        }   
                        } while (dataValida == false);

                    

                        Console.WriteLine($"Digite o CPF da Pessoa Física que deseja cadastrar");
                        novaPf.cpf = Console.ReadLine();

                        Console.WriteLine($"Digite o RENDIMENTO da Pessoa Física que deseja cadastrar");
                        novaPf.rendimento = float.Parse(Console.ReadLine());

                        
                        Console.WriteLine($"Digite o LOGRADOURO da Pessoa Física que deseja cadastrar");
                        novoEnd.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o NUMERO da Pessoa Física que deseja cadastrar");
                        novoEnd.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o COMPLEMENTO da Pessoa Física que deseja cadastrar");
                        novoEnd.complemento = Console.ReadLine();
                        
                        Console.WriteLine($"Esse endereço é comercial? S/N");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEnd.endComercial = true;
                        } else
                        {
                            novoEnd.endComercial = false;
                        }

                        
                        novaPf.endereco = novoEnd;

                        listaPf.Add(novaPf);

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Cadastro Concluído!!");
                        Thread.Sleep(3000);
                        Console.ResetColor();

                    break;

                    case "2":
                    
                        Console.Clear();

                        if (listaPf.Count > 0)
                        {
                            foreach (PessoaFisica cadaPessoa in listaPf)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
                                Nome: {cadaPessoa.nome}
                                Endereço: {cadaPessoa.endereco.logradouro}, {cadaPessoa.endereco.numero}
                                Data de Nascimento: {cadaPessoa.dataNascimento}
                                Taxa de Imposto a Ser Paga é: {metodoPf.PagarImposto(cadaPessoa.rendimento).ToString("C")}
                                ");

                                Console.WriteLine($"Aperte Enter para Continuar");
                                Console.ReadLine();
                            }


                        } else
                        {
                            Console.WriteLine($"Lista Vazia!!!!");
                            Thread.Sleep(2000);
                        }

                        
                    break;

                    case "0":
                    break;

                    default:
                        Console.WriteLine($"Opção Inválida!!!");
                        Thread.Sleep(1000);
                    break;
                }
                
            } while (opcaoPf != "0");

           
        break;

        case "2":
            
            PessoaJuridica metodoPj = new PessoaJuridica();

            string? opcaoPj;
            do
            {
                    Console.Clear();
                    Console.WriteLine(@$"
                ======================================
                | ESCOLHA UMA DAS OPÇÕES ABAIXO      |
                --------------------------------------
                |       1 - Cadastrar PJ             |
                |       2 - Mostrar PJ               |
                |                                    |
                |       0 - Retornar ao Menu Inicial |             
                ======================================
                ");

                opcaoPj = Console.ReadLine();

                switch (opcaoPj)
                {
                    case "1":
                        PessoaJuridica novaPj = new PessoaJuridica();
                        Endereco novoEndPj = new Endereco();
                        
                        Console.WriteLine($"Digite o NOME da EMPRESA que deseja cadastrar");
                        novaPj.razaosocial = Console.ReadLine();

                        bool cnpjvalido;
                        do
                        {
                            Console.WriteLine($"Digite o CNPJ que deseja cadastrar");
                            string? cnpj = Console.ReadLine();
                            cnpjvalido = metodoPj.ValidarCNPJ(cnpj);

                            if(metodoPj.ValidarCNPJ(cnpj)){

                                novaPj.cnpj = cnpj;
                                
                            } else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"CNPJ INVÁLIDO!!");
                                Console.ResetColor();
                            }

                        } while(cnpjvalido == false);

                        Console.WriteLine($"Digite o RENDIMENTO da EMPRESA que deseja cadastrar");
                        novaPj.rendimento = float.Parse(Console.ReadLine());
                        
                        Console.WriteLine($"Digite o LOGRADOURO da EMPRESA");
                        novoEndPj.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o NUMERO");
                        novoEndPj.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o COMPLEMENTO da EMPRESA que deseja cadastrar");
                        novoEndPj.complemento = Console.ReadLine();

                        novoEndPj.endComercial = true;

                        novaPj.endereco = novoEndPj;

                        listaPj.Add(novaPj);

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Cadastro Concluído!!");
                        Thread.Sleep(3000);
                        Console.ResetColor();
                    break;

                    case "2":

                        if (listaPj.Count > 0)
                        {
                            foreach (PessoaJuridica cadaPJ in listaPj)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
                                Nome: {cadaPJ.razaosocial}
                                CNPJ: {cadaPJ.cnpj}
                                Endereço: {cadaPJ.endereco.logradouro}, {cadaPJ.endereco.numero}
                                Taxa de Imposto a Ser Paga é: {metodoPj.PagarImposto(cadaPJ.rendimento).ToString("C")}
                                ");

                                Console.WriteLine($"Aperte Enter para Continuar");
                                Console.ReadLine();
                            }


                        } else
                        {
                            Console.WriteLine($"Lista Vazia!!!!");
                            Thread.Sleep(2000);
                        }
                    break;

                    case "0":
                    break;

                    default:
                        Console.WriteLine($"Opção Inválida!!!");
                        Thread.Sleep(1000);
                    break;
                }    

            }    while (opcaoPj != "0");
            
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