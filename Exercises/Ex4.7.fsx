let rec multiplicity(x,xs) =
    match xs with
    |[] -> 0
    |n::tail when x=n -> 1 + multiplicity(x,tail)
    |n::tail -> multiplicity(x,xs)
