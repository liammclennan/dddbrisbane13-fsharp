<Query Kind="FSharpProgram" />

// tuples and pattern matching
// (and typesafe string interpolation)

let location = -27.43, 153.1

let printHemisphere = function
		| lat, _ when lat > 0. 	-> 
			sprintf "Northern hemisphere because %.2f is > 0" lat
		| lat, _ -> 
			sprintf "Southern hemisphere because %.2f is <= 0" lat
	
printHemisphere location 
	|> Console.WriteLine
	