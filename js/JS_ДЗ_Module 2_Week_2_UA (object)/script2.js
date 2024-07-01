let bill = [
    {
        name: "Milk",
        amount: 7,
        price: 100
    },
    {
        name: "Bread",
        amount: 1,
        price: 10
    },
    {
        name: "Apple",
        amount: 5,
        price: 50
    },
    {
        name: "Egg",
        amount: 10,
        price: 70
    }
]

function showBill(arr) {
    for (let item of arr) {        
        console.log(`${item.name} - ${item.price} x ${item.amount}`)                
    }
}

function calculateTotal(arr) {
    let total = 0
    for (let item of arr) {
        total += item.price * item.amount
    }
    return total
}

function getTheMostExpensivePurchase(arr) {
    let max = 0;
    for(let item of arr) {
        if (max < item.amount * item.price) {
            max = item.amount * item.price
        }
    }
    return arr.filter(item => item.amount * item.price == max)
}

function calculateAverage(arr) {
    let sum = 0
    for (let item of arr) {
        sum += item.price
    }
    return sum / arr.length
}

// showBill(bill)

// console.log("Total: ", calculateTotal(bill))

// showBill(getTheMostExpensivePurchase(bill))

// console.log(calculateAverage(bill))