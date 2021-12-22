int nn = 0;
int nk = 0;
double a = 0;

Console.WriteLine("Enter nn ");
nn = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter nk ");
nk = Convert.ToInt32(Console.ReadLine());

if (nn < 0 || nn > nk) {
    Console.WriteLine("Error! Not valid nn or nk!");
} else
{
    for (int k = nn; k <= nk; k++)
    {
        a += (double)(k ^ 2 - 1)/((-1)^(k+1)*k^2+7);
    }
    Console.WriteLine("Result a = " + a);
}




