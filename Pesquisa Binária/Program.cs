using System.Runtime.CompilerServices;
//var contador = 0;

//var lista = new List<int> { 1, 2, 3, 5, 7 };

//Console.WriteLine("Pesquisa Binária");
//Console.WriteLine("Index: " + PesquisaBinaria(lista, 7));
//Console.WriteLine($"Foi necessário {contador} etapas");
//Console.WriteLine("");

//Console.WriteLine("--------------------------");
//Console.WriteLine("");
//Console.WriteLine("Pesquisa Simples");
//Console.WriteLine("Index: " + PesquisaSimples(lista, 7));
//Console.WriteLine($"Foi necessário {contador} etapas");


//int? PesquisaBinaria(IList<int> lista, int item)
//{
//    var baixo = 0;
//    var alto = lista.Count - 1;

//    while (baixo <= alto)
//    {
//        var meio = (baixo + alto) / 2;
//        var adivinhar = lista[meio];
//        if (adivinhar == item)
//        {
//            return meio;
//        }

//        if (adivinhar > item)
//        {
//            contador++;

//            alto = meio - 1;
//        }
//        else
//        {
//            contador++;

//            baixo = meio + 1;
//        }
//    }

//    return null;
//}




//Exercício 1
//Suponha que você tenha uma lista com 128 nomes e esteja fazendo uma pesquisa binária.
//Qual seria o número máximo de etapas que você levaria para encontrar o nome desejado?

var listaOrdenada = new List<int>();
int quantEtapas = 0;
for (int i = 0; i < 128; i++)
{
    listaOrdenada.Add(i);
}

Console.WriteLine("Index: " + PesquisaBinariaListaOrdenada(listaOrdenada, 127));
Console.WriteLine($"Etapas: {quantEtapas}");

int? PesquisaBinariaListaOrdenada(IList<int> lista, int item)
{
    int baixo = 0;
    int alto = lista.Count - 1;


    while (baixo <= alto)
    {
        int meio = (baixo + alto) / 2;
        int adivinhar = lista[meio];

        if (adivinhar == item)
        {
            return meio;

        }

        if (adivinhar > item)
        {
            alto = meio - 1;

            quantEtapas++;
        }
        else
        {
            baixo = meio + 1;

            quantEtapas++;
        }
    }
    return null;
}

//Exercício 2
//Suponha que você duplique o tamanho da lista. Qual seria o número máximo de etapas agora?

var contador = 0;

IList<int> lista = new List<int>();
for (int i = 0; i < 256; i++)
{
    lista.Add(i);
}

Console.WriteLine("Index: " + PesquisaBinaria(lista, 255));
Console.WriteLine("Etapas: " + contador);

int? PesquisaBinaria(IList<int> lista, int item)
{
    int baixo = 0;
    int alto = lista.Count - 1;

    while (baixo <= alto)
    {
        var media = (baixo + alto) / 2;
        var adivinha = lista[media];

        if (adivinha == item)
        {
            return media;
        }

        if (adivinha > item)
        {
            alto = media - 1;
            contador++;

        }
        else
        {
            baixo = media + 1;
            contador++;
        }
    }

    return null;
}

//Pesquisa Simples
var contadorPesquisaSimples = 0;
int? PesquisaSimples(IList<int> lista, int item)
{
    for (var i = 0; i < lista.Count; i++)
    {
        var adivinha = lista[i];

        if (adivinha == item)
        {
            return lista[i];
        }
        contadorPesquisaSimples++;
    }

    return null;
}
