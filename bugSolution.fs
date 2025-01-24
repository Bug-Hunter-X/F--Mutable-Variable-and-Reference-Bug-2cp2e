let mutable x = 10
let y = &x

//Modifying the value of x will not change the value of y.
//Because y is a reference to x which holds the value 10, but is not a pointer to x.
x <- 20
printfn "%A" y // Output: 10

//To modify y you must dereference it.
!y <- 30
printfn "%A" x // Output: 30