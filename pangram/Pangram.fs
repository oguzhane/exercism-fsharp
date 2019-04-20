module Pangram
open System

// inclusive 'betwwen' operator
let (>=<) x (min, max) =
    (x >= min) && (x <= max)
    
let let2nat (letter : char) = int letter - int 'a'

let isPangram (input: string): bool = 
  match Seq.length input with
  | i when i > 25 -> input.ToLower() |> Seq.distinct |> Seq.filter (fun c -> let2nat c >=< (0, 25)) |> Seq.length |> (fun len -> len = 26)
  | i -> false
  