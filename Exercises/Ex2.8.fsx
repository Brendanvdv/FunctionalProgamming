let rec bin(n,k) = 
    match (n,k) with 
    |(n,0) -> 1
    |(n,k) when k=n -> 1
    |(n,k) ->bin(n-1,k-1)+bin(n-1,k)