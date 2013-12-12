<Query Kind="FSharpProgram" />

// type inference

let square x = x * x

Console.WriteLine (square 3.0)
Console.WriteLine (square 3) // no type coercion here

//--