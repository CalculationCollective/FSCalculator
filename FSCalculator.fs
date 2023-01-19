open System

Console.Write("Enter the first number: ")
let num1 = Double.Parse(Console.ReadLine())

Console.WriteLine("Choose between:\n1) Addition\n2) Subtraction\n3) Multiplication\n4) Division")
let calculationType = Int32.Parse(Console.ReadLine())

Console.Write("Enter the second number: ")
let num2 = Double.Parse(Console.ReadLine())

let result =
    match calculationType with
    | 1 -> num1 + num2
    | 2 -> num1 - num2
    | 3 -> num1 * num2
    | 4 -> num1 / num2
    | _ -> 0.0
    
Console.WriteLine(result)