module Bob

open System

let (|Question|_|) (input:string) =
    if input.EndsWith("?") then Some Question else None

let (|Yell|_|) (input:string) =
    if input |> Seq.exists Char.IsLetter && input |> Seq.exists Char.IsLower |> not then Some Yell else None

let (|NoSaying|_|) (input:string) =
    if String.IsNullOrWhiteSpace(input) then Some NoSaying else None

let response (input: string): string = 
  match input.Trim() with
  | Question & Yell -> "Calm down, I know what I'm doing!"
  | Yell -> "Whoa, chill out!" 
  | Question  -> "Sure." 
  | NoSaying -> "Fine. Be that way!" 
  | _ -> "Whatever."

