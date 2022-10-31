using System.Diagnostics;
using System.Drawing;
using testingLab2;

int Fib(int N)
{
    if (N < 2)
    {
        return 1;
    }
    else
    {
        return Fib(N - 1) + Fib(N - 2);
    }
}

// AlgorithmB algorithmB = new AlgorithmB();

int.TryParse(Console.ReadLine(), out int R);

Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();

for (int i = 0; i < 4; i++)
{
    new Thread(() =>
    {
        Fib(R);

        stopwatch.Stop();

        Console.WriteLine(stopwatch.ElapsedMilliseconds);

    }).Start();
}



// algorithmB.FillCircle(new Bitmap(2 * R, 2), Color.Red, new Point(R, R), R);

