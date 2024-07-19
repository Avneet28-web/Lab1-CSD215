let rec productOfList list =
    match list with
    | [] -> 1 
    | head :: tail -> head * productOfList tail 
let numbers = [2; 3; 4; 5]
let product = productOfList numbers
printfn "Product of all elements: %d" product

let productOfOddNumbers (n: int) =
    let rec helper (current: int) (acc: int) =
        if current <= 1 then acc
        elif current % 2 = 0 then helper (current - 1) acc // Skip even numbers
        else helper (current - 2) (acc * current) // Multiply odd number and recurse with n-2
    helper n 1

let number = 11
let result = productOfOddNumbers number
printfn "Product of all odd numbers from %d to 1: %d" number result

let trimNames (names: string list) =
    names |> List.map (fun x -> x.Trim())

let list = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]
let trimmedNames = trimNames list

trimmedNames |> List.iter (printfn "%s")


let sequence = seq { 1 .. 700 }

let numberList = Seq.toList sequence

let filteredList = List.filter (fun x -> x % 35 <> 0) numberList

let sumOfFilteredNumbers = List.fold (+) 0 filteredList

printfn "Filtered List: %A" filteredList

printfn "The sum of all numbers that are not multiples of both 7 and 5 is %d" sumOfFilteredNumbers


let names = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]

let filteredNames = names |> List.filter (fun name -> name.ToLower().Contains("i"))

let concatenatedNames = filteredNames |> List.fold (fun acc name -> acc + name) ""

printfn "Concatenated names containing 'I': %s" concatenatedNames



