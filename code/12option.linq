<Query Kind="FSharpProgram" />

let divide a b = 
	if b = 0. 
		then None 
		else Some(a / b)

let s = match divide 19. 6. with 
			| None -> "--"
			| Some(v) -> v.ToString()

s |> Console.WriteLine