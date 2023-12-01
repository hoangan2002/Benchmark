// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using DoBenmark;

Console.WriteLine("Hello, World!");
BenchmarkRunner.Run<BenchmarkHarness>();
Console.ReadLine();