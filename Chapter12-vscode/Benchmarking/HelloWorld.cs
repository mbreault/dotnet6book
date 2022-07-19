using BenchmarkDotNet.Attributes; // [Benchmark]
public class HelloWorld
{
    [Benchmark(Baseline = true)]
    public void Control()
    {
        for (int i; i < 10000; i++)
        {
            string s = "Hello, World!";
        }
    }

    [Benchmark]
    public void Test()
    {
        for (int i; i < 10000; i++)
        {
            var s = "Hello, World!";
        }
    }
}