// Exercício do site URI "Sequência Lógica"

int N = int.Parse(Console.ReadLine());

int Num1 = 1;
int Num2 = 1;
int Num3 = 1;

for(int i = 1; i <= N; i ++)
{
    for(int j = 1; j <= 2; j ++)
    {
        Console.WriteLine(Num1 + " " + Num2 + " " + Num3);
        Num2 = Num2 + 1;
        Num3 = Num3 + 1;
    }
    Num1 = Num1 + 1;
    Num2 = Num1 * Num1;
    Num3 = Num1 * Num2;
}