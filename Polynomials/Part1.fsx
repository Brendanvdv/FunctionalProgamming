//* 1.1 The function add:
let rec add a b =
    match a, b with 
    |[],[]              -> []                           // sum of two empty lists is an empty list
    |a::atail, b::btail -> (a+b) :: (add atail btail)   // sum of non-empty lists is sum of their tails prepended with sum of their heads
    |a,[] -> a
    |[],b -> b

//let l1 = [1;2];;
//let l2 = [3;4;5;6];;
//=  [4;6;5;6]

//* 1.2 The function mulC:
let rec mulC p c=
    match p with
    |[] -> []
    |p::ptail -> (p*c) :: (mulC ptail c)


//* 1.3 The subtraction function sub: 
let rec sub a b = 
    match a,b with 
    |[],[] -> []
    |a,[] -> a
    |[],b -> b
    |a::atail, b::btail -> (a-b) :: (sub atail btail)

//* 1.4 The function mulX:
let mulX a = [0]@a

//* 1.5 The multiplication function mul:

//? use subfunctions: mulc for a0*Q(x) and mulx for x*(...)
    //  |a,[] -> a
    // |[],b -> b
    // |a,[0] -> [0]
    // |[0],b -> [0]            

let rec mul p1 = function
    |[] -> []
    |a::atail -> add (mulC p1 a) (mulX (mul p1 atail))

//
//[2;4] [1;3] -> 2 + 4x , 1 + 3x
//1) (mulc p1 a) : 1*2 = 2 
//2) [2;4] [3] -> 2+4x , 3x
//2) mulx(mulc p1 a) : (2+4x)*3x = 6x + 12x^2


// Edit boop
//* 1.6 The function eval:

let f x = x +2

let rec eval p a =
    match p,a with 
    |[],_ -> 0
    |x::xs,0 -> x 
    |x::xs,_ -> x + a*(eval xs a)

// [1;2] 2
//1)1 + 2(2) = 5