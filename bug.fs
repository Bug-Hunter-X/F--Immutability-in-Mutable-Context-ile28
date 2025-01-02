let mutable x = 1
let mutable y = 2
let z = x + y
printf "%d" z
x <- 3
printf "%d" z // z still prints 3, not 4 because z was evaluated before the change to x