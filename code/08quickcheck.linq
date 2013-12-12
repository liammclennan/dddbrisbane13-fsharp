<Query Kind="FSharpProgram">
  <NuGetReference>FsCheck</NuGetReference>
  <Namespace>FsCheck</Namespace>
  <Namespace>FsCheck.Fluent</Namespace>
</Query>

// a different way to add 2 numbers
let add x y = 
	List.fold (+) 0 (x :: [y])

add 1 3 |> Console.WriteLine
add 7 -4 |> Console.WriteLine

// a property
let addProducesSum x y = x + y = add x y 

//Check.Quick addProducesSum














//let add' x y = 
//	List.fold (+) 0 (abs x :: [y])

//add' 1 3 |> Console.WriteLine
//add' 7 -4 |> Console.WriteLine

//let add'ProducesSum x y = x + y = add' x y 
	
//Check.Quick add'ProducesSum












//let makePropertyFor f x y = x + y = f x y
//
//Check.Quick (makePropertyFor add)
//Check.Quick (makePropertyFor add')