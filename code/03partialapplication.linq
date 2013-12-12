<Query Kind="FSharpProgram" />

//partial application

let add x y = x + y

let add1 = add 1

Console.WriteLine (add 1 3)
Console.WriteLine (add1 3)