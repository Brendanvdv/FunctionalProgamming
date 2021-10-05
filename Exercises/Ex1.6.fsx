let rec sum(m, n) = 
    match (m, n) with 
    | (m,0) -> m + 0
    | (m,n) -> m + sum(m,n-1)


