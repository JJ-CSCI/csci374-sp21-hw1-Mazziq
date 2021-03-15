module Assignment

// Problem 1
let rec tribn n =
    // write your code here
    if n <= 0 then 0
    else if n = 1 then 1
    else if n = 2 then 1
    else tribn (n-1) + tribn (n-2) + tribn (n-3)

// Problem 2
let tribn2 n =
    // write your code here
     if n = 0 then 0
  else if n =1 then 1
  else if n = 2 then 1
  else (tribn2 (n - 1) + tribn2 (n - 2) + tribn2 (n - 3))

// Problem 3
let rec last lst =
    // write your code here
    if lst.Tail.IsEmpty then
  List.head lst
    else last (List.tail lst)

// Problem 4
let fourth (lst:int list) =
    // write your code here
     if list = [] then 0
    else if list.Tail = [] then 0
    else if list.Tail.Tail = [] then 0
    else if list.Tail.Tail.Tail = [] then 0
    else list.Tail.Tail.Tail.Head

// Problem 5
let everyfourth (lst:int list) =
    // write your code here
    if list = [] then []
    else if list.Tail = [] then []
    else if list.Tail.Tail = [] then []
    else if list.Tail.Tail.Tail = [] then []
    else  list.Tail.Tail.Tail.Head :: everyfourth list.Tail.Tail.Tail.Tail
// Problem 6
let rec take n (lst:int list) =
    // write your code here
    if n = 0 then []
    else if list.IsEmpty then []
    else list.Head :: take (n-1) list.Tail 

// Problem 7
let rec drop n (lst:int list) =
    // write your code here
    []
