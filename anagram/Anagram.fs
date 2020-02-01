module Anagram

let detectAnagram (word:string, target:string) = 
  word = word.ToLower()



let findAnagrams sources target = 
  let targetSorted = (Seq.sort target).ToString().ToLower()
  sources |> List.filter (fun (x:string) -> 
    let word = x.ToLower(); 
    word = targetSorted && 
    )