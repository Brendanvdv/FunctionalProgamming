//2*3 + 4;;

//let price = 25*5;;
//let newPrice = 2*price;
//newPrice > 500;

//let x = 4;;

//let f x = 2*x + 1;;
//let g x = f(f x);;

//let rec power(x,n) = 
//    match n with 
//    |0 -> 1.0
//    |_ -> x*power(x,n-1);;

let rec member (x, ys) =
        match ys with 
        |[] -> false
        |y::tail -> x = y || member(x,tail)

       

let rex insert(x, xs) =
        match xs with
        |[] -> false
        |y;;ys when x


let stuff = 2::[1;4];;