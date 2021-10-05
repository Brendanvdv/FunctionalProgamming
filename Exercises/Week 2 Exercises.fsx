
//*Exercise 2.1

let f = function
    |n when n%5=0 -> false
    |n when n%3=0 -> true
    |n when n%2=0 -> true
    |_ -> false

//f(24) = true
//f(27) =true
//f(29) = false
//f(30) = false

//*Exercise 2.2

let rec pow s n =
    match n with
    |x when x<= 0-> ""    
    |x -> s + pow s (n-1)

//pow "ding" 3;;

//*Excersise 4.3

let rec evenN n =
    match n with 
    |x when x <= 0 -> []
    |x when n % 2=0 ->[n] @evenN (n-1)
    |x when n % 2 <> 0 -> []

let evenN n =
    match n with
    |x when x <= 0 -> []
    |x -> [2 .. n]

let evenN n =
    [for x in 2..2..n do yield x]

// for x in start..step..end

//*Exercise 4.8

let rec split a =
    match a with 
    |[] -> ([],[])
    |[x0] ->([x0],[])
    |[x0,x1] -> ([x0],[x1])
    |x0::x1::xt  -> let (r1, r2) = split xt
                    (x0::r1, x1::r2)
    
    let rec split items = 
    match items with
    | [] -> ([],[])
    | [x0] -> ([x0],[])
    | [x0;x1] -> ([x0],[x1])
    | x0::x1::xs -> let (r1, r2) = split xs
                    (x0::r1, x1::r2)