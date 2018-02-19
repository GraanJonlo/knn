open System
open FSharp.Data
open FSharp.Data.Runtime

type Iris =
    {
        featureVector: double list
        label: string
    }

let square x = x * x

let distance x y =
    Seq.zip x y
    |> Seq.sumBy (fun (l,r) -> (l - r) ** 2.0)
    |> sqrt

[<EntryPoint>]
let main argv =
    let irises =
        CsvFile.Load("G:/projects/src/scratch/lambda/knn/iris.data").Rows
        |> Seq.map (fun x ->
            {
                featureVector =
                    [
                        double(x.Item("A"))
                        double(x.Item("B"))
                        double(x.Item("C"))
                        double(x.Item("D"))]
                label = x.Item("Label") })
    0
