int stockLimit = 2;
string[] productName = new string[stockLimit];
int[] productQuantity = new int[stockLimit];
double[] productPrice = new double[stockLimit];
int[] productCod = new int[stockLimit];
bool[] productAvailable = new bool[stockLimit];

int optionUser = 0;
bool openMenu = true;


while (openMenu)
{

    Console.WriteLine("\n =========================================");
    Console.WriteLine("||                                       ||");
    Console.WriteLine("||  SISTEMA DE GERENCIAMENTO DE ESTOQUE  ||");
    Console.WriteLine("||                                       ||");
    Console.WriteLine(" =========================================\n\n");

    Console.WriteLine("       ESCOLHA UMA OPÇÃO:\n\n");

    Console.Write(" 1 - Adicionar produto\n");
    Console.Write(" 2 - Listar produtos\n");
    Console.Write(" 3 - Consultar produto\n");
    Console.Write(" 4 - Atualizar estoque\n");
    Console.Write(" 5 - Alterar disponibilidade\n");
    Console.Write(" 6 - Sair\n\n");

    Console.Write("Opção escolhida: ");
            
    optionUser = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (optionUser)
    {
        case 1:
            {
                bool productAdd = false;
                for (int i = 0; i < stockLimit; i++)
                {
                    if (productCod[i] == 0 && productAdd == false)
                    {
                        Console.WriteLine("Cadastro de produtos:\n");

                        Console.Write("Digite o código: ");
                        int.TryParse(Console.ReadLine(), out productCod[i]);

                        Console.Write("Digite o nome: ");
                        productName[i] = Console.ReadLine();

                        Console.Write("Digite a quantidade: ");
                        int.TryParse(Console.ReadLine(), out productQuantity[i]);

                        Console.Write("Digite o preço: ");
                        double.TryParse(Console.ReadLine(), out productPrice[i]);

                        Console.Write($"Disponível? (S / N): ");
                        if (Console.ReadLine() == "S")
                        {
                            productAvailable[i] = true;
                        }
                        else if (Console.ReadLine() == "N")
                        {
                            productAvailable[i] = false;
                        }

                        productAdd = true;

                        Console.WriteLine("\n* * * Produto adicionado com sucesso! * * *\n\n");
                       
                    }
                }
                if (!productAdd)
                {
                    Console.WriteLine("\n\nNão há espaço para adicionar mais produtos!\n\n");
                }

                Console.WriteLine($"\n\n***Tecle [ENTER] para voltar ao menu!***");
                Console.ReadKey();
                Console.Clear();
                break;
            }



        case 2:
            {

                        
                Console.WriteLine("===   LISTA DE PRODUTOS DISPONÍVEIS   ===\n");

                for (int i = 0; i < stockLimit; i++)
                {
                    if (productCod[i] != 0 && productAvailable[i] == true)
                    {
                        Console.WriteLine($"Código:........................ {productCod[i]}");
                        Console.WriteLine($"Nome:.......................... {productName[i]}");
                        Console.WriteLine($"Quantidade em estoque:......... {productQuantity[i]}");
                        Console.WriteLine($"Preço:......................... R${productPrice[i]:F2}\n");

                        Console.WriteLine("\n==========================================\n");
                    }
                }
                        




                Console.WriteLine($"\n\n***Tecle [ENTER] para voltar ao menu!***");
                Console.ReadKey();
                Console.Clear();
                break;
            }


        case 3:
            {                       
                Console.Write("Digite o código do produto que deseja consultar: ");
                int consultCod = int.Parse(Console.ReadLine());
                bool found = false;
                for (int i = 0; i < stockLimit; i++)
                {
                    if (productCod[i] == consultCod)
                    {

                        found = true;


                        if (productAvailable[i])
                        {
                            Console.WriteLine($"\nCódigo:........................ {productCod[i]}");
                            Console.WriteLine($"Nome:.......................... {productName[i]}");
                            Console.WriteLine($"Quantidade em estoque:......... {productQuantity[i]}");
                            Console.WriteLine($"Preço:......................... R${productPrice[i]:F2}");
                            Console.WriteLine($"Disponível?.................... {productAvailable[i]}");
                            Console.WriteLine($"\n\n");
                        }

                        else
                        {
                            Console.WriteLine($"O produto com código {consultCod} não está disponível.");
                        }


                    }
                }
                if (!found)
                {
                    Console.WriteLine($"O produto com código {consultCod} não foi encontrado.");
                }

                        




                Console.WriteLine($"\n\n***Tecle [ENTER] para voltar ao menu!***");
                Console.ReadKey();
                Console.Clear();
                break;
            }


        case 4:
        {
            Console.Write("Digite o código do produto que deseja alterar a quantidade: ");
            int updateCode = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < stockLimit; i++)
            {
                if (productCod[i] == updateCode)
                {
                    found = true;


                    Console.WriteLine($"Código: {productCod[i]} | Nome: {productName[i]} | Quantidade: " +
                        $"{productQuantity[i]} | Preço: R${productPrice[i]:F2} | Disponível? {productAvailable[i]}");


                    if (productAvailable[i])
                    {
                        Console.Write("\nDigite a nova quantidade em estoque: ");
                        productQuantity[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n * * * Estoque atualizado com sucesso! * * *\n\n");
                    }
                    else
                    {
                        Console.WriteLine("O produto não está disponível!");
                    }

                }
            }

            if (!found)
            {
                Console.WriteLine("Produto não encontrado!");
            }





            Console.WriteLine($"\n\n***Tecle [ENTER] para voltar ao menu!***");
            Console.ReadKey();
            Console.Clear();
            break;
        }


        case 5:
        {

                        
            Console.Write("Digite o código do produto que deseja atualizar a disponibilidade: ");
            int updateCodeQuantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < stockLimit; i++)
            {
                if (productCod[i] == updateCodeQuantity)
                {
                    productAvailable[i] = !productAvailable[i];
                    Console.WriteLine($"Disponibilidade do produto {productName[i]} alterada com sucesso!");

                }
            }

            Console.WriteLine("Produto não encontrado!");

                        




            Console.WriteLine($"\n\n***Tecle [ENTER] para voltar ao menu!***");
            Console.ReadKey();
            Console.Clear();
            break;
        }

        case 6:
            Console.WriteLine("\n\n################################");
            Console.WriteLine("\n\n\n#    PROGRAMA FINALIZADO!!!    #\n\n\n\n");
            Console.WriteLine("################################\n\n");
            openMenu = false;
            return;


        default:
            {
                Console.WriteLine("Numero invalido, digite outro numero: ");

                Console.WriteLine($"\n\n***Tecle [ENTER] para voltar ao menu!***");
                Console.ReadKey();
                Console.Clear();
                break;
            }

    }

} 




