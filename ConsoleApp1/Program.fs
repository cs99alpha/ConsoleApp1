// Learn more about F# at http://fsharp.org

//open System
module HelloSquare

let square x = x * x

[<EntryPoint>]
let main argv =
    //printfn "Hello World from F#!"
    printfn "%d squared is: %d!" 12 (square 12)
    0 // return an integer exit code

