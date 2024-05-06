//5 -) Cadastre 10 números em uma fila dinâmica e outros 10 numa pilha dinâmica, em seguida, mostre os três relatórios:
//a) Os números que estão nas duas estruturas;
//b) Os que estão na fila;
//c) Os que estão na pilha;

using Ex_05___Pilha_e_Fila;

int numeroDigitado;
FilaDinamica Fila = new FilaDinamica();
PilhaDinamica Pilha = new PilhaDinamica();

Console.WriteLine("--- Cadastrar Números na Fila ---");
for (int contador = 0; contador < 10; contador++)
{
    Console.Write($"{contador+1}º número: ");
    numeroDigitado = int.Parse( Console.ReadLine() );
    Numero n = new Numero(numeroDigitado);
    Fila.ReceberNumFila(n);
}

Console.Clear();

Console.WriteLine("--- Cadastrar Números na Pilha ---");
for (int contador = 0; contador < 10; contador++)
{
    Console.Write($"{contador+1}º número: ");
    numeroDigitado = int.Parse(Console.ReadLine());
    Numero num = new Numero(numeroDigitado);
    Pilha.AdicionarNumPilha(num);
}

//Imprimir os valores da fila
Fila.ImprimirNumFila();
Console.WriteLine();
Console.WriteLine("Aperte enter...");
Console.Clear();

//Imprimir os valores da pilha
Pilha.MostrarNumPilha();
Console.WriteLine();
Console.WriteLine("Aperte enter...");
Console.ReadKey();