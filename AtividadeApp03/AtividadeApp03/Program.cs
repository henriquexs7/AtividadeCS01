// See https://aka.ms/new-console-template for more information
// O código vai soma a cada numero declarado, ou seja, 1 + 1 = 2, 2 + 1 = 3,
// 3 + 2 = 5, 5 + 3 = 8 ... até finalizar o código.
var fibonacciNumbers = new List<int> { 1, 1 };

while (fibonacciNumbers.Count < 20)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);
}
foreach (var item in fibonacciNumbers)
    Console.WriteLine(item);
