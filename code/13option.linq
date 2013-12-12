<Query Kind="FSharpProgram" />

let divide a b = 
	if b = 0. 
		then None 
		else Some(a / b)

// a pipeline of operations. Try changing the denominator to 0
let r = divide 19. 6. 
			|> Option.bind (fun v -> Some(v * 2.))
			|> Option.bind (fun v -> Some(sqrt v))

// unpack the option
let s = match r with 
			| None -> "--"
			| Some(v) -> v.ToString()

s |> Console.WriteLine