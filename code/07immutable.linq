<Query Kind="FSharpProgram" />

// immutable collections 

let list = ['d'..'v']

let longerList = 'a' :: 'b' :: 'c' :: list

let allAlpha = longerList @ ['w'..'z']

list
//longerList
//allAlpha 
	|> Console.WriteLine