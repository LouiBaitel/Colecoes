using System;
using System.Collections.Generic;
using Colecoes.Helper;
using System.Linq;

namespace Colecoes
{
    class Program
    {
        static void Main (string[] args)
        {

            // -------------------------------- Criando o array Unidimensional -------------------------------

            // int [] arrayInteiros = new int [3]; //definida a capacidade máxima de 3 parametros para esse array

            // //Adicionando valores específicos em cada posição do array
            // arrayInteiros [0] = 17;
            // arrayInteiros [1] = 23;
            // arrayInteiros [2] = int.Parse ("31"); //realiza a conversão da string para inteiro, desde que seja um numeral

            // --------------------------------- Acesso aos elemntos do array -------------------------------

            //arrayInteiros [3] = 62; // Perceba que o VS Code não acusa erro, mas se rodarmos o programa, essa posição não será impressa
                                    // Pois não está dentro da capacidade máxima definida
                                    // Poderá ser impressa caso se realize a adição dessa posição
            // ---------------------------------- Formas de percorrer o array --------------------------------

            // System.Console.WriteLine("Percorrendo o array pelo for");
            // for (int i = 0; i < arrayInteiros.Length; i++) //Com .Length podemos percorrer o valor total do array criado, utilizando a capacidade máxima.
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("Percorrendo o array pelo foreach");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }

            // ----------------------------------- Criando um array multidimensional ------------------------

            // int [,] matriz = new int [4,2] // definimos a quantidade de linhas e colunas, nessa ordem.
            // // abaixo fazemos a definição das 4 linhas e duas colunas
            // {
            //     { 8, 8 },
            //     { 40, 56},
            //     { 50, 87},
            //     { 53, 14}

            // };

            // for (int i = 0; i < matriz.GetLength(0); i++) // .GetLength pega a dimensão do array

            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matriz[i, j]); //percorre a linha e a coluna do array
            //     }

            // }

            // // matriz [0,0] = 5; //Aqui definimos os valores da posição de linha 0 e posição de coluna 0

            //----------------------------------- Bubble Sort -----------------------------------------------

            // OperacoesArray op = new OperacoesArray();

            // int[] array = new int [5] {5, 6, 7, 3, 9};
            // int[] arrayCopia = new int[10];

            // int valorProcurado = 10;
            // int valorAchado = op.ObterValor(array, valorProcurado);

            // System.Console.WriteLine("Array Original");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array Ordenado por Bubble sort");
            // op.OrdenarBubbleSort(ref array);
            // op.ImprimirArray(array);

            //----------------------------------- Classe Array ---------------------------------------------

            // System.Console.WriteLine("Array Ordenado pela classe Array");
            // op.Ordenar(ref array);
            // op.ImprimirArray(array);

            //--------------------------------------- Copiando um Array -----------------------------------

            // System.Console.WriteLine("Array antes da cópia");
            // op.ImprimirArray(arrayCopia);

            // System.Console.WriteLine("Array após a cópia:");
            // op.Copiar(ref array, ref arrayCopia);
            // op.ImprimirArray(arrayCopia);

            //---------------------------------------- Verificando se um elemnto existe --------------------

            // bool existe = op.Existe(array, valorProcurado);
            // if (existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não encontrado: {0}", valorProcurado);
            // }

            //------------------------------ Verificando todos os elementos do array ------------------------

            // bool TodosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            // if (TodosMaiorQue)
            // {
            //     System.Console.WriteLine("Todos os valores são maiores que {0}!", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Alguns valores não são maiores que {0}!", valorProcurado);
            // }


            //-------------------------- Encontrando um elemento no array ----------------------------------

            // if (valorAchado > 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor");
            // }

            //----------------------------------Encontrando o index do elemento ----------------------------

            // int indice = op.ObterIndice(array, valorProcurado);

            // if (indice > -1)
            // {
            //     System.Console.WriteLine("O indice do elemento {0} é: {1}", valorProcurado, indice);
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor inexistente no array");
            // }

            //------------------------------ Redimensionando um array ---------------------------------------

            // System.Console.WriteLine($"Capacidade atual do array: {array.Length}.");

            // op.RedimensionarArray(ref array, array.Length * 2);

            // System.Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}.");

            //------------------------------- Convertendo um array -----------------------------------------

            // string[] arrayString = op.ConverterParaString(array);

            //------------------------------------- Declarando e acessando uma lista -------------------------

            // OperacoesLista opLista = new OperacoesLista();
            // List<string> Estados = new List<string>(); //declaração da lista
            // Estados.Add("SP");
            // Estados.Add("MG");
            // Estados.Add("PR");

            // System.Console.WriteLine($"Quantidade de elementos na lista: {Estados.Count}");

            //Formas de imprimir a lista

            // foreach (var item in Estados)
            // {
            //     System.Console.WriteLine(item);
            // }

            //ou

            // for (int i = 0; i < Estados.Count; i++)
            // {
            //     System.Console.WriteLine($"índice {i}, valor: {Estados[i]}");
            // }

            //ou (utilizando um método)

            // opLista.ImprimirListaString(Estados);

            //------------------------------- Remover elemento da lista -------------------------------------

            // System.Console.WriteLine("Removendo o elemento...");
            // Estados.Remove("MG");
            // System.Console.WriteLine("Lista atualizada:");
            // opLista.ImprimirListaString(Estados);

            //-------------------------------- Adicionando coleções na lista --------------------------------

            // string[] estadosArray = new string[2] {"SC", "MT"};

            // Estados.AddRange(estadosArray); //Adiciona um array na lista (desde que seja do mesmo tipo)

            // opLista.ImprimirListaString(Estados);


            //------------------------------- Adicionando elementos por índice -----------------------------

            // Estados.Insert(1, "RJ"); //indica-se primeiro o índice e depois o elemento que será adicionado

            // opLista.ImprimirListaString(Estados);

            // --------------------------------------- Filas ----------------------------------------------

            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("Antonho");//Adiciona um objeto no final da fila
            // fila.Enqueue("Craudia");
            // fila.Enqueue("Jusé");
            // fila.Enqueue("Matias");
            // fila.Enqueue("Déquini"); 

            // // fila.Dequeue(); //Remove e retorna o objeto atual no começo da fila
            // // fila.Peek(); //retorna o elemento ao inicio da fila, sem remove-lo
            // // fila.Count(); //Faz a contagem dos elementos na fila
            
            // System.Console.WriteLine("Pessoas na fila:", fila.Count);
            // while (fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Vez de: {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()} atendido(a)");
            // }

            //-------------------------------------- Pilhas -----------------------------------------------

            // Stack<string> PilhaLivros = new Stack<string>();

            // PilhaLivros.Push(".NET"); //Insere um objeto no topo da pilha
            // PilhaLivros.Push("DDD"); 
            // PilhaLivros.Push("Código limpo"); 

            // // PilhaLivros.Pop(); //Remove um objeto do topo da pilha
            // // PilhaLivros.Peek(); //Informa o ultimo objeto no topo, sem remove-lo

            // System.Console.WriteLine($"Livros para a leitura: {PilhaLivros.Count}.");
            // while(PilhaLivros.Count > 0)
            // {
            //     System.Console.WriteLine($"Próximo livro para leitura: {PilhaLivros.Peek()}.");
            //     System.Console.WriteLine($"Lido com sucesso: {PilhaLivros.Pop()}!");
            //     break;
            // }

            // System.Console.WriteLine($"Livros para a leitura: {PilhaLivros.Count}.");

            //-------------------------------- Dicionário ------------------------------------------------

            // Dictionary<string,string> estados = new Dictionary<string, string>();

            // // Não é possivel adicionar chaves iguais
            // estados.Add("SP", "São Paulo");
            // estados.Add("PR", "Paraná");
            // estados.Add("RJ", "Rio de Janeiro");

            // foreach (KeyValuePair<string,string> item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}.");
            // }

            // //------------------------------ Acessando um valor -------------------------------------------

            // System.Console.WriteLine();
            // string ValorProcurado = "SP";
            // System.Console.WriteLine("O valor original é:" + estados[ValorProcurado]);

            // //--------------------------------- Atualizando um valor -------------------------------------

            // System.Console.WriteLine();
            // estados[ValorProcurado] = "SP - Teste da atualização";
            // System.Console.WriteLine("O valor atualizado é:" + estados[ValorProcurado]);

            // //--------------------------------Removendo um valor -----------------------------------------

            // System.Console.WriteLine();
            // System.Console.WriteLine($"Removendo o valor: {ValorProcurado}");
            // estados.Remove(ValorProcurado);
            
            // System.Console.WriteLine();
            // System.Console.WriteLine("Dicionário atualizado");
            // foreach (KeyValuePair<string,string> item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}.");
            // }
            
            // //----------------------------- Acessando de maneira segura---------------------------------

            // System.Console.WriteLine();
            // if(estados.TryGetValue(ValorProcurado, out string estadoEncontrado))
            // {
            //     System.Console.WriteLine(estadoEncontrado);
            // }
            // else
            // {
            //     System.Console.WriteLine($"Chave {ValorProcurado} não existe no dicionário");
            // }

            //------------------------------- LINQ - Obtendo e ordenando valores ---------------------------

            int[] arrayNumeros = new int[10] {1, 4, 5, 16, 19, 100, 0, 100, 0, 1};

            var numerosParesQuery =
                        from num in arrayNumeros
                        where num % 2 == 0
                        orderby num
                        select num;

            var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            System.Console.WriteLine("Números pares query: " + string.Join(", ", numerosParesQuery));
            System.Console.WriteLine("Números pares método: " + string.Join(", ", numerosParesMetodo));

            //------------------------- Valores mínimo, máximo e médio ------------------------------------

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();

            System.Console.WriteLine();
            System.Console.WriteLine($"Mínimo {minimo}, máximo {maximo} e médio {medio}");

            //---------------------------------- Sum e Distinct ------------------------------------------

            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray(); //Distinct retorna elements distintos de uma sequência
                                                                // ToArray retorna um array de inteiros
            System.Console.WriteLine();
            System.Console.WriteLine($"A soma é: {soma}");

            System.Console.WriteLine();
            System.Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)})");
            System.Console.WriteLine($"Array distinto: {string.Join(", ", arrayUnico)})");

        }
    }
}


