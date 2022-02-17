// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Cadastro_Pessoa_FS1.Classes;

PessoaFisica metodoPf = new PessoaFisica();

PessoaFisica novaPf = new PessoaFisica();


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

Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
Maior de Idade: {metodoPf.ValidarDataNasc(novaPf.dataNascimento)}");


//novaPf.ValidarDataNasc(new DateTime(2000,01,01));

//PessoaJuridica metodoPj = new PessoaJuridica();
//PessoaJuridica novaPj = new PessoaJuridica();
//Endereco novoEndPj = new Endereco();

//novaPj.nome = "Teste pj";
//novaPj.cnpj = "00.000.000./0001-00";
//novaPj.razaosocial = "Teste Razao PJ";
//novaPj.rendimento = "10000";

//novoEndPj.logradouro = "Teste logradouro";
//novoEndPj.numero = "";
//novoEndPj.complemento = "";
//novoEndPj.endComercial = "";//