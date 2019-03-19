module Hamming
open System.Collections.Generic

let distance (strand1: string) (strand2: string): int option=
  match Seq.length strand1 = Seq.length strand2 with
    | true -> (Seq.toList strand1, Seq.toList strand2) ||> List.zip |> List.filter (fun (x, y) -> x <> y) |> List.length |> Some
    | _ -> None