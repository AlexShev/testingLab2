using System.Diagnostics;
using System.Drawing;
using testingLab2;

AlgorithmB algorithmB = new AlgorithmB();

int R = 10000;

Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();

algorithmB.FillCircle(new Bitmap(2 * R, 2 * R), Color.Red, new Point(R, R), R);

stopwatch.Stop();

Console.WriteLine(stopwatch.ElapsedMilliseconds);