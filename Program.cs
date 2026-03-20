//Objetivos 
//V1
///Nossa calculadora deve ter a possibilidade de somar dois números
//Nossa calculadora deve ter a possibilidade de subtrair dois números
//Nossa calculadora deve ter a possibilidade de multiplicar dois números
//Nossa calculadora deve ter a possibilidade de dividir dois números
//Nossa calculadora deve permitir que o usuário continue utilizando o sistema até decidir sair
//Nossa calculdadora deve permitir realizer diversar operações
//V2
//Estruturas de repetição 
//Enquanto
//Nossa calculadora deve exibir a tabuada de um numero informado
//Nossa calculadora deve armazenar historio de operações

string[] historicoOperacoes = new string[100];
int contadorOperacoes = 0;

while (true == true)
{
    Console.Clear();

    Console.WriteLine("------------------------");
    Console.WriteLine("*** Calculadora 2026 ***");
    Console.WriteLine("------------------------");
    Console.WriteLine(" 1 - Somar");
    Console.WriteLine(" 2 - Subitrair");
    Console.WriteLine(" 3 - Multiplicar");
    Console.WriteLine(" 4 - Dividir");
    Console.WriteLine(" 5 - Tabuada");
    Console.WriteLine(" 6 - Histórico");
    Console.WriteLine(" S - Sair");
    Console.WriteLine("------------------------");
    Console.WriteLine("Escolha uma opção valida: ");
    string opcao = Console.ReadLine();

    if (opcao == "S" || opcao == "s")
    {
        break;
    }
    if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "6")
    {
        Console.WriteLine("------------------------");
        Console.WriteLine("*** Opção invalida! ***");
        Console.WriteLine("------------------------");

        Console.WriteLine("Precione ENTER para sair!");
        Console.ReadLine();

        continue;
    }
    if (opcao == "5")
    {
        Console.Clear();
        Console.WriteLine("------------------------");
        Console.WriteLine("*** Tabuada! ***");
        Console.WriteLine("------------------------");
        Console.Write("Digite um número inteiro: ");
        string strintnumeroDigitado = Console.ReadLine();

        int numeroDigitado = Convert.ToInt32(strintnumeroDigitado);

        Console.WriteLine("Digite o multiplicador MAXIMO da tabuada!");
        int multiplicadorMaximoTabuada = Convert.ToInt32(Console.ReadLine());

        for (int iterador = 1; iterador <= multiplicadorMaximoTabuada; iterador = iterador + 1)
        {
            string linhaTabuada = $" {numeroDigitado} x {iterador} = {numeroDigitado * iterador}";
            Console.WriteLine(linhaTabuada);
        }
        Console.WriteLine("-------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
        continue;
    }
    if (opcao == "6")
    {
        Console.Clear();
        Console.WriteLine("------------------------");
        Console.WriteLine("*** Historico de operações***");
        Console.WriteLine("------------------------");

        for (int iterador = 0; iterador < historicoOperacoes.Length; iterador++)
        {
            if (historicoOperacoes[iterador] == null)
            {
                Console.WriteLine(historicoOperacoes[iterador]);
            }

        }
        Console.WriteLine("-------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
        continue;
    }

    Console.Write(" Digite o primeiro número:  ");
    string strprimeiroNumero = Console.ReadLine();

    int primeiroNumero = Convert.ToInt32(strprimeiroNumero);

    Console.Write("O Primeiro numero digitado foi: " + primeiroNumero);

    Console.Write(" Digite o segundo número:  ");
    string strsegundoNumero = Console.ReadLine();

    int segundoNumero = Convert.ToInt32(strsegundoNumero);

    int resultado = 0;
    string textoOperacao = "";

    if (opcao == "1")
    {
        resultado = primeiroNumero + segundoNumero;
        textoOperacao = $"´{primeiroNumero} + {segundoNumero} = {resultado}";
    }
    else if (opcao == "2")
    {
        resultado = primeiroNumero - segundoNumero;
        textoOperacao = $"´{primeiroNumero} - {segundoNumero} = {resultado}";
    }
    else if (opcao == "3")
    {
        resultado = primeiroNumero * segundoNumero;
        textoOperacao = $"´{primeiroNumero} * {segundoNumero} = {resultado}";
    }
    else if (opcao == "4")
    {
        resultado = primeiroNumero / segundoNumero;
        textoOperacao = $"´{primeiroNumero} / {segundoNumero} = {resultado}";
    }
    if (contadorOperacoes < historicoOperacoes.Length)
    {
        historicoOperacoes[contadorOperacoes] = textoOperacao;
        contadorOperacoes++;
    }
    else
    {
        historicoOperacoes = new string[100];
        contadorOperacoes = 0;

        historicoOperacoes[contadorOperacoes] = textoOperacao;
        contadorOperacoes++;
    }

    Console.Write("O resultado é: " + resultado);
    Console.ReadLine();
}
