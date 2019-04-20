module Bob


let isQuestion (input:string) : bool = 
  input.Length > 0 && 
  input.[input.Length - 1] = '?' 

let isYell (input:string): bool =
  let inputSet = set (input)
  Set.intersect (inputSet) (set ['a'..'z']) |> Set.count = 0 && Set.intersect (inputSet) (set ['A'..'Z']) |> Set.count > 0

let isYellWithQuestion (input:string): bool = 
  isQuestion input && isYell input

let noSaying (input:string): bool =
  let inputSet = set (input)
  Set.intersect (inputSet) (set ['a'..'z']) |> Set.count = 0 
  && Set.intersect (inputSet) (set ['A'..'Z']) |> Set.count = 0
  && Set.intersect (inputSet) (set ['0'..'9']) |> Set.count = 0
 
let response (input: string): string = 
  match input.Trim() with
  | s when isYellWithQuestion s = true -> "Calm down, I know what I'm doing!"
  | s when isYell s = true -> "Whoa, chill out!" 
  | s when isQuestion s = true -> "Sure." 
  | s when noSaying s = true -> "Fine. Be that way!" 
  | _ -> "Whatever."

