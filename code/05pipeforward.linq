<Query Kind="FSharpProgram" />

// pipe-forward operator

let add1 = (+) 1
let square n = n * n

add1 0 |> add1 |> add1 |> add1 |> square |> Console.WriteLine