int num;
Console.WriteLine("\tPRIMO\n");

bool ehPrimo(int num) {

    if (num <= 1)
        return false;

    int contador = 0;

    for (int i = 1; i <= num; i++) {
        
        if(num % i == 0)
            contador++;

        if (contador > 2)
            return false;
    }
    if (contador == 2)
        return true;
    else
        return false;

}

Console.WriteLine("Digite um numero: ");
num = int.Parse(Console.ReadLine());
Console.WriteLine("\n");

void sequenciaPrimo(int num)
{
    for(int i = 1; i <= num; i++)
    {
        if (ehPrimo(i))
            Console.WriteLine(i + " é primo");
        else
            Console.WriteLine(i);
    }
}

sequenciaPrimo(num);

