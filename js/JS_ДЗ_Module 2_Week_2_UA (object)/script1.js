let shoppingList = [
    {
        name: "Milk",
        amount: 2,
        bought: true
    },
    {
        name: "Bread",
        amount: 1,
        bought: false
    },
    {
        name: "Apple",
        amount: 5,
        bought: true
    },
    {
        name: "Egg",
        amount: 10,
        bought: false
    }
]

function showArray(arr) {
    arr.sort((a, b) => a.bought - b.bought)
    for (let item of arr) {
        console.log(item)
    }
}

function addProduct(arr, item) {
    let exist = arr.find(el => el.name === item.name)
    if (exist) {
        exist.amount += item.amount
        return
    }    
    arr.push(item)
}

function buyProduct(arr, name) {
    let el = arr.find(item => item.name === name)
    if (el) {
        el.bought = true
    }        
}

// showArray(shoppingList)

addProduct(shoppingList,  {
    name: "Egg",
    amount: 20,
    bought: false
})
addProduct(shoppingList,  {
    name: "Meat",
    amount: 2,
    bought: false
})
// showArray(shoppingList)

buyProduct(shoppingList, "Egg")
// showArray(shoppingList)

