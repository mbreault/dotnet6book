﻿using System.Diagnostics; // Stopwatch
using static System.Console;

static void OutputThreadInfo()
{
    Thread t = Thread.CurrentThread;
    WriteLine(
      "Thread Id: {0}, Priority: {1}, Background: {2}, Name: {3}",
      t.ManagedThreadId, t.Priority,
      t.IsBackground, t.Name ?? "null");
}

static void MethodA()
{
  WriteLine("Starting Method A...");
  OutputThreadInfo();
  Thread.Sleep(3000); // simulate three seconds of work
  WriteLine("Finished Method A.");
}
static void MethodB()
{
  WriteLine("Starting Method B...");
  OutputThreadInfo();
  Thread.Sleep(2000); // simulate two seconds of work
  WriteLine("Finished Method B.");
}
static void MethodC()
{
  WriteLine("Starting Method C...");
  OutputThreadInfo();
  Thread.Sleep(1000); // simulate one second of work
  WriteLine("Finished Method C.");
}

OutputThreadInfo();
Stopwatch timer = Stopwatch.StartNew();
WriteLine("Running methods synchronously on one thread."); 
MethodA();
MethodB();
MethodC();
WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms elapsed.");

WriteLine("Running methods asynchronously on multiple threads."); 
timer = Stopwatch.StartNew();
Task taskA = new(MethodA);
taskA.Start();
Task taskB = Task.Factory.StartNew(MethodB); 
Task taskC = Task.Run(MethodC);
WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms elapsed.");
