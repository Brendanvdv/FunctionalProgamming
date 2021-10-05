

//let g n = n + 4;;

//let h (x:float) (y:float) = System.Math.Sqrt(x**2.0 + y**2.0);;

// 1.4

let rec f n =
    match n with 
    | 0 -> 0
    | _ -> n + f(n-1)

//f 2 -> f(2-1)+2 -> f(1) +2 -> f(0-1)+1+2 -> f(0-1) + 1 + 2 -> 0 + 1 +2 = 3

// f(-1) -> f(-1-1) + -1 -> f(-2) + - 1 -> f(-2-1) + -2 + -1 : Overflow



