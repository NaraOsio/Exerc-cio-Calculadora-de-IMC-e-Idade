//declara variavel para o loop
var opcao = "";

do
{
    //Declare variáveis para armazenar altura, peso, idade e nome da pessoa.
    //Utilize tipos primitivos adequados

    // mostra a mensagem pedindo para o usuário digitar o nome 
    Console.WriteLine("Digite o seu nome");

    // Console.ReadLine le o nome do usuário 
    string nome = Console.ReadLine();

    // mostra a mensagem pedindo para o usuário digitar a altura
    Console.WriteLine("Digite sua altura");

    //Console.ReadLine le altura do usuário, e converte para um tipo double
    var altura = double.Parse(Console.ReadLine());

    //mostra mensagem pedindo o peso
    Console.WriteLine("Digite peso");

    // Console.ReadLine  ler o peso do usuario, converte para um float
    float peso = float.Parse(Console.ReadLine());

    //mostra mensagem pedindo para o usuário digitar a idade
    Console.WriteLine("Digite sua idade");

    //Console.ReadLine le a idade do usuario e converte para inteiro
    int idade = int.Parse(Console.ReadLine());



    //Operadores Aritméticos
    //○ Calcule o IMC usando a fórmula: IMC = peso / (altura * altura)

    //Calculo do IMC peso e altura
    var imc = peso / (altura * altura);




    //Instruções de Seleção
    //Use if, if-else para determinar a categoria de IMC e a faixa etária da pessoa.

    //verifica a faixa de IMC do usuário
    string faixaImc = "";
    if (imc < 18.5)
    {
        faixaImc = "Abaixo do peso";
    }
    else if (imc >= 18.6 && imc <= 24.9)
    {
        faixaImc = "Peso normal";
    }
    else if (imc >= 25 && imc <= 29.9)
    {
        faixaImc = "Sobrepeso";
    }
    else if (imc >= 30)
    {
        faixaImc = "Obesidade";
    }


    //verifica a idade e imprime a faixa etaria
    string faixaEtaria = "";
    if (idade < 10)
    {
        faixaEtaria = "Criança";
    }
    else if (idade >= 10 && idade < 20)
    {
        faixaEtaria = "Adolescente";
    }
    else if (idade >= 20 && idade < 60)
    {
        faixaEtaria = "adulto";
    }
    else if (idade >= 60)
    {
        faixaEtaria = "idoso";
    }



    //Formatação de Strings
    //○ Utilize concatenação e interpolação de strings para gerar o relatório final

    //Console.WriteLine impreime o nome do usuario
    Console.WriteLine($"Nome: {nome}");

    //Console.WriteLine exibe o IMC do usuário
    Console.WriteLine("Idade: " + idade);

    Console.WriteLine("IMC: " + imc);

    Console.WriteLine("Faixa imc: " + faixaImc);

    Console.WriteLine("Faixa etaria: " + faixaEtaria);

    Console.WriteLine("Gostaria de fazer um novo teste?");



    //pede para digitar se quer continuar ou não
    opcao = Console.ReadLine();


 while (opcao != "nâo");   //continua o loop enquanto não digitar a palabra não