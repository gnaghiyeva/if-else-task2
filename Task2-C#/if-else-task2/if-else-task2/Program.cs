// See https://aka.ms/new-console-template for more information

double result = 1;
int t = 10;

if (t > 0 && t <= 3)
{
    result = t * 1;
}
else if (t == 4 || t == 5)
{
    result = 3 + ((t - 3) * 0.8);
}

else if (t > 5 && t <= 8)
{
    result = (4.6 + ((t - 5) * 0.50));
}

else
{
    result = (6.1 + ((t - 8) * 0.25));
}

Console.Write(result);
