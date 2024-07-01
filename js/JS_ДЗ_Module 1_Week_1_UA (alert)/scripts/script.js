// 1
let userName = prompt("Enter your name")
alert("Привіт, " + userName + "!")

// 2
let birthday = new Date(Date.parse(prompt("Enter your date of birth (yyyy-mm-dd)")))
const currentDate = new Date()
 
let age = Math.floor((currentDate - birthday) / (1000 * 3600 * 24 * 365)); 
alert("Age: " + age)

// console.log("date of birth\n", birthday.toISOString())
// console.log("current date\n", currentDate.toISOString())

// 3
let sideOfSquare = parseFloat(prompt("Enter the side of square"))
alert("Perimeter of square: " + sideOfSquare * 4)

// 4
let radius = parseFloat(prompt("Enter the radius of circle"))
alert("S = " + Math.pow(radius, 2) * Math.PI)

// 5
let distance = parseFloat(prompt("Enter the distance (km)"))
let time = parseFloat(prompt("Enter the time (h)"))
alert("Speed: " + distance / time + " km/h")

// 6
const rateUsdEur = 0.93
let usd = parseFloat(prompt("Enter usd"))
alert("Usd:" + usd + "\nEur: " + usd * rateUsdEur)

// 7
let memorySizeGb = parseInt(prompt("Enter the size of memory stick:"))
alert("You can save " + Math.floor(memorySizeGb / 0.82) + " file with size 820 Mb")

// 8
let money = parseFloat(prompt("Enter the amount of money"))
let price = parseFloat(prompt("Enter the price of chocolate"))
alert("You can buy " + Math.floor(money / price) + " chocolates\nRemainder: " + (money - price * Math.floor(money / price)))

// 9
let number = parseInt(prompt("Enter the number"))
let reverseNumber = 0
while (number) {    
    reverseNumber *= 10    
    reverseNumber += number % 10;
    number = parseInt(number / 10)
}
alert("Reverse: " + reverseNumber)

// 10
let n = parseInt(prompt("Enter the number"));
(n % 2) && alert("Odd");
!(n % 2) && alert("Even");