// let num1 = parseInt(prompt("Enter number1 = "))
// let num2 = parseInt(prompt("Enter number2 = "))
// let res = num1 + num2
// alert("Sum num1 + num2 = " + res)

let number = parseInt(prompt("Enter number"))

function loopDoWhile(n) {
    console.log("do while")
    let i = 0;
    do {
        console.log(i++)        
    } while (i <= n)
}

function loopWhile(n) {
    console.log("while")
    let i = 0;
    while (i <= n) {
        console.log(i++)
    }
}

function loopFor(n) {
    console.log("for")
    for (let i = 0; i <= n; i++) {
        console.log(i)
    }
}

loopDoWhile(number)
loopWhile(number)
loopFor(number)