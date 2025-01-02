let mutable x = 1
let mutable y = 2
let z = ref (x + y) //Use a reference cell to store the sum
printf "%d" !z // Dereference the reference cell
x <- 3
printf "%d" !z //Prints 5
y <- 4
printf "%d" !z //Prints 7
//Modify value in the reference cell to reflect changes in x and y
//Note that we cannot directly assign to z, because it would try to create another copy of the cell.
z := x + y //Modify the value held by the reference cell
printf "%d" !z //Prints 7