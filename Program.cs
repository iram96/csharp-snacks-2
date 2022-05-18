// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Scrivere un codice csharp che crea un accumulatore e poi lo utilizza
//Esempio: var accumulatore1 = CreaAccumulatore();
//accumulatore1(10) => 10
//accumulatore1(40) => 50
//accumulatore1(90) => 140



var Maker = () =>
{
    long totale = 0;
    return (int n) =>
    {
        totale += n;
        return totale;
    };
};

var acc1 = Maker();
var acc2 = Maker();
Console.WriteLine(acc1(10));
Console.WriteLine(acc1(10));
Console.WriteLine(acc1(10));
Console.WriteLine(acc2(10));
Console.WriteLine(acc2(10));
Console.WriteLine(acc2(10));


//Data una lista di interi ,metterli tutti al quadrato

List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
List<int> lQuadrato = Quadrato(list);
foreach (int n in list)
{
    Console.WriteLine(n);
}
List<int> Quadrato(List<int> l)
{
    List<int> result = new List<int>();

    foreach (int n in l)
    {
        result.Add(n * n);
    }
    return result;
}

foreach (int n in lQuadrato)
{
    Console.WriteLine(n);
}

//Ora realizzare un metodo che esegue l'elevamento al cubo

//List<int> lCubo = Cubo(list);


/*List<int> Cubo(List<int> list2)
{
    List<int> result = new List<int>();

    foreach (int n in list)
    {
        result.Add(n * n * n);
    }
    return result;
}

foreach (int n in lCubo)
{
    Console.WriteLine(n);
}*/

//FUNZIONE GENERALE
int MettiAllaQuinta(int i)
{
    return i * i * i * i * i;
}
List<int> lquinta = EseguiIlCalcolo(list, MettiAllaQuinta);
foreach (int n in lquinta)
    Console.WriteLine(n);

List<int> EseguiIlCalcolo(List<int> li, Func<int, int> fun)
{
    List<int> lout = new List<int>();
    foreach (int n in li)
        lout.Add(fun(n));
    return lout;
}

List<int> lcalcolo = EseguiIlCalcolo(list, (n) => n * (n + 1) / 2);
foreach (int n in lcalcolo)
    Console.WriteLine(n);


//Abbiamo in questo modo costruito una funzione "generale" per trasformare
//tutti gli elementi di una stringa da numero intero a numero intero => nuovo = f(vecchio);
//Purtroppo per come è stata costruita, questa funzione si applica esclusivamente alle lista di numeri interi 
//e torna una lista di numeri interi

List<string> ls = new List<string>() { "uno", "due", "tre", "quattro", "cinque" };



var lslen = ls.Select(s => s.Length);
foreach (int s in lslen)
    Console.WriteLine(s);

//ordinare una lista di interi
List<int> li = new List<int>() { 8, 4, 67, 12, 43, 91, 0, 1, 2, 3, 5, 5 };
li.Sort();
li.Reverse();  //se la volessi al contrario
foreach (int n in li)
    Console.WriteLine(n);
Console.WriteLine("\n\n\n\n");
li = new List<int>() { 8, 4, 67, 12, 43, 91, 0, 1, 2, 3, 5, 5 };
li.Sort((int v1, int v2) =>
{
    if (v1 < v2)
        return -1;
    if (v1 == v2)
        return 0;
    else
        return 1;
});
foreach (int n in li)
    Console.WriteLine(n);
//crescente
Console.WriteLine("\n\n\n\n");
li = new List<int>() { 8, 4, 67, 12, 43, 91, 0, 1, 2, 3, 5, 5 };
li.Sort((int v1, int v2) =>
{
    if (v1 < v2)
        return 1;
    if (v1 == v2)
        return 0;
    else
        return -1;
});
foreach (int n in li)
    Console.WriteLine(n);
//Data la lista di stringhe {"uno", "due", "tre", "quattro", "cinque", "Sei"}
//ordinarla e stamparla in verso decrescente
Console.WriteLine("\n\n\n\n");
List<string> miaLista = new List<string> { "uno", "due", "tre", "quattro", "cinque", "Sei" };

miaLista.Sort();
miaLista.Reverse();
foreach (string s in miaLista)
    Console.WriteLine(s);


SortedSet<string> ords = new SortedSet<string>();
foreach (string s in miaLista)
    ords.Add(s);
foreach (string s in ords)
    Console.WriteLine(s);


//Data una lista di coppie <string, int>, stamparle ordinate
//rispetto alla stringa
//coppia --> Tuple<string, int> 
//quindi una lista di coppie sarà : 

Console.WriteLine("\n\n\n\n");

List<Tuple<string, int>> lista = new List<Tuple<string, int>>() {
                      new Tuple<string, int>("uno", 1),
                      new Tuple<string, int>("due", 21),
                      new Tuple<string, int>("quattro", 34),
                      new Tuple<string, int>("sette", 82),
                      new Tuple<string, int>("diciannove", 91)};


lista.Sort();
var newLista = lista.Select(s => s.Item1 + "" + s.Item2);

lista.ForEach(x => Console.WriteLine(x));
Console.WriteLine(string.Join("\t", lista));


foreach (string s in newLista)
    Console.WriteLine(s);

//Ordinare per il secondo campo della tupla

lista.Sort((t1, t2) => t1.Item2.CompareTo(t2.Item1));
Console.WriteLine(string.Join("\t", lista));

lista.Sort();
lista.Sort((t1, t2) => t1.Item2 - t2.Item2);
Console.WriteLine(string.Join("\t", lista));

double microseconds = DateTime.Now.Ticks / (TimeSpan.TicksPerMillisecond / 1000.0);
Console.WriteLine("microseconds: {0}", microseconds);






