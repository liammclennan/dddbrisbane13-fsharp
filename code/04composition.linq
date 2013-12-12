<Query Kind="FSharpProgram" />

// composition

let add1 = (+) 1

let square n = n * n

add1 15 	|> Console.WriteLine
square 7	|> Console.WriteLine

let add1AndSquare = square << add1

//add1AndSquare 6 |> Console.WriteLine

//List.map (square << add1) [1..10] |> Console.WriteLine