<Query Kind="FSharpProgram">
  <NuGetReference>FSharp.Charting</NuGetReference>
  <Namespace>FSharp.Charting</Namespace>
</Query>

type point =
    | TwoD of int * int
    | ThreeD of int * int * int
	
let p1 = TwoD (5, 14)
let p2 = ThreeD (1, 4, 2)

open FSharp.Charting

// a function that works for any point
let plot (p:point) = 
	match p with
		// pattern matching union cases,
		| TwoD(x,y) -> Chart.Point([ x,y ]) 
		// de-structuring the tuple
		| ThreeD(x,y,z) -> Chart.Point([x,y])   

(plot (TwoD (3,7))).ShowChart()
//(plot (ThreeD (1,2,3))).ShowChart()






// a recursive type
type tree =
    | Leaf of int
    | Node of tree * tree
 
let simpleTree =
    Node(
        Leaf 1,
        Node(
            Leaf 2,
            Node(
                Node(
                    Leaf 4,
                    Leaf 5
                ),
                Leaf 3
            )
        )
    )
 
printfn "%A" simpleTree