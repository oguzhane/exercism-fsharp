module Proverb

let rec reciteBody (input:string list): string list =
  match input with
    | [_] | [] -> []
    | first :: rest -> [sprintf "For want of a %s the %s was lost." first rest.Head] @ reciteBody rest
  

let recite (input: string list): string list = 
  reciteBody input @ (if input.Length = 0 then [] else [sprintf "And all for the want of a %s." input.Head]) 