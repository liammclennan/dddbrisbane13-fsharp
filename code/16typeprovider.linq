<Query Kind="FSharpProgram">
  <NuGetReference>FSharp.Charting</NuGetReference>
  <NuGetReference>FSharp.Data</NuGetReference>
  <Namespace>FSharp.Charting</Namespace>
</Query>

open FSharp.Data

// generate Rating type at compile time
type Rating = CsvProvider<"D:\\movies.csv">

// load data as instances of Rating
let movieRatings = Rating.Load("D:\\movies.csv")

let first = Seq.head movieRatings.Data
first.title |> Console.WriteLine
first.score * 2m |> Console.WriteLine
first.boxoffice |> Console.WriteLine

//Chart.Point([ for d in movieRatings.Data -> d.boxoffice, d.score ]).ShowChart()