Console.WriteLine($"OLÁ SEJA MUITO BEM VINDO AO NOSSO BAR. =)");
Thread.Sleep(1000);
Console.WriteLine($"IREMOS EXIBIR NOSSA CARDAPIO COM BEBIDAS..... =)");
Thread.Sleep(1000);
Console.Clear();

here:
Console.WriteLine($"HOJE ESSAS ESSAS SÃO NOSSAS OPÇÕES HOJE.");
Console.WriteLine($"1. Caipirinha............. R$15,00");
Console.WriteLine($"2. Dry Martini............ R$21,00");
Console.WriteLine($"3. Negroni................ R$19,00");
Console.WriteLine($"4. Aperol Spritz.......... R$18,00");
Console.WriteLine($"5. Royal Salute........... R$35,00");

Console.WriteLine($"PARA ESCOLAR BASTA DIGITAR O NUMERO DO DRINK QUE VOCÊ QUEIRA EXPERIMENTAR");
int escolha = int.Parse(Console.ReadLine());


switch (escolha)
{
    case 1:

        Console.WriteLine($"VOCE ESCOLHEU A CAIPIRINHA");
        Console.WriteLine($"GOSTARIA DO ADICIONAL DE GELO");
        Console.WriteLine($"CASO QUEIRA DIGITE 'S' PARA SIM E 'N' PARA NAO");
        string gelo = Console.ReadLine().ToLower();
        Thread.Sleep(1000);
        if (gelo == "s")
        {
            Console.WriteLine($"ADICIONAL DE GELO COLOCADO ");
            Console.WriteLine($"VALOR COBRADO A MAIS SERA DE R$3,00");
            Thread.Sleep(900);

            Console.WriteLine($"O Valor do seu DRINK e R$18,00");
        }

        else
        {
            Console.WriteLine($"COMO VOCE NAO ADICIONOU O GELO ");
            Console.WriteLine($"ENTAO FICOU R$15,00");
        }
        break;

    case 2:

        Console.WriteLine($"VOCE ESCOLHEU O DRY MARTINI");
        Console.WriteLine($"GOSTARIA DO ADICIONAL DE GELO");
        Console.WriteLine($"CASO QUEIRA DIGITE 'S' PARA SIM E 'N' PARA NAO");
        gelo = Console.ReadLine().ToLower();
        Thread.Sleep(1000);

        if (gelo == "s")
        {
            Console.WriteLine($"ADICIONAL DE GELO COLOCADO ");
            Console.WriteLine($"VALOR COBRADO A MAIS SERA DE R$3,00");
            Thread.Sleep(900);

            Console.WriteLine($"O Valor do seu DRINK e R$24,00");
        }

        else
        {
            Console.WriteLine($"COMO VOCE NAO ADICIONOU O GELO ");
            Console.WriteLine($"ENTAO FICOU R$21,00");
        }
        break;

    case 3:

        Console.WriteLine($"VOCE ESCOLHEU O NEGRONI");
        Console.WriteLine($"GOSTARIA DO ADICIONAL DE GELO");
        Console.WriteLine($"CASO QUEIRA DIGITE 'S' PARA SIM E 'N' PARA NAO");
        gelo = Console.ReadLine().ToLower();
        Thread.Sleep(1000);

        if (gelo == "s")
        {
            Console.WriteLine($"ADICIONAL DE GELO COLOCADO ");
            Console.WriteLine($"VALOR COBRADO A MAIS SERA DE R$3,00");
            Thread.Sleep(900);

            Console.WriteLine($"O Valor do seu DRINK e R$22,00");
        }

        else
        {
            Console.WriteLine($"COMO VOCE NAO ADICIONOU O GELO ");
            Console.WriteLine($"ENTAO FICOU R$19,00");
        }
        break;

    case 4:

        Console.WriteLine($"VOCE ESCOLHEU O APEROL SPRITZ");
        Console.WriteLine($"GOSTARIA DO ADICIONAL DE GELO");
        Console.WriteLine($"CASO QUEIRA DIGITE 'S' PARA SIM E 'N' PARA NAO");
        gelo = Console.ReadLine().ToLower();
        Thread.Sleep(1000);

        if (gelo == "s")
        {
            Console.WriteLine($"ADICIONAL DE GELO COLOCADO ");
            Console.WriteLine($"VALOR COBRADO A MAIS SERA DE R$3,00");
            Thread.Sleep(900);

            Console.WriteLine($"O Valor do seu DRINK e R$21,00");
        }

        else
        {
            Console.WriteLine($"COMO VOCE NAO ADICIONOU O GELO ");
            Console.WriteLine($"ENTAO FICOU R$18,00");
        }
        break;

    case 5:

        Console.WriteLine($"VOCE ESCOLHEU O ROYAL SALUTE");
        Console.WriteLine($"GOSTARIA DO ADICIONAL DE GELO");
        Console.WriteLine($"CASO QUEIRA DIGITE 'S' PARA SIM E 'N' PARA NAO");
        gelo = Console.ReadLine().ToLower();
        Thread.Sleep(1000);

        if (gelo == "s")
        {
            Console.WriteLine($"ADICIONAL DE GELO COLOCADO ");
            Console.WriteLine($"VALOR COBRADO A MAIS SERA DE R$3,00");
            Thread.Sleep(900);

            Console.WriteLine($"O Valor do seu DRINK e R$38,00");
        }

        else
        {
            Console.WriteLine($"COMO VOCE NAO ADICIONOU O GELO ");
            Console.WriteLine($"ENTAO FICOU R$35,00");
        }
        break;

        default:
        Console.WriteLine($"OPCAO ERRADA, TENTE NOVAMENTE");
        Thread.Sleep(2000);
        goto here;
        break;
        

}






