// 1
function showArray(arr) {
    for (let i in arr) {
        console.log(arr[i])
    }
}

//showArray([2, 1, 4, 5, 3])

// 2
function showEven(arr) {
    for (let i in arr) {
        if (arr[i] % 2 === 0) {
            console.log(arr[i])
        }
    }
}

// showEven([2, 1, 4, 5, 3])

// 3
function getSum(arr) {
    s = 0
    for (let i in arr) {
        s += arr[i]
    }
    return s
}

// console.log(getSum([2, 1, 4, 5, 3]))

// 4
function getMax(arr) {
    max = Number.MIN_SAFE_INTEGER
    for (let i in arr) {
        if (arr[i] > max) {
            max = arr[i]
        }
    }
    return max
}

// console.log(getMax([2, 1, 4, 5, 3]))

// 5
function insertAtIndex(index, n, arr) {    
    let newArr = new Array()
    for (let i = 0; i < arr.length; i++) {
        if (i == index) {
            newArr.push(n)
        }
        newArr.push(arr[i])            
    }
    if (index >= arr.length) {
        newArr.push(n);
    }
    return newArr
}

let a = [2, 1, 4, 5, 3]
a = insertAtIndex(2, 100, a)
//showArray(a)

// 6
function deleteAtIndex(index, arr) {    
    let newArr = new Array()
    for (let i = 0; i < arr.length; i++) {
        if (i == index) {
            continue
        }
        newArr.push(arr[i])            
    }    
    return newArr
}

a = deleteAtIndex(2, a)
a = deleteAtIndex(2, a)
// showArray(a)

// 7
function uniteArrs(arr1, arr2) {    
    let newArr = new Array()
    for (let i = 0; i < arr1.length; i++) {
        newArr.push(arr1[i])            
    }    
    for (let i = 0; i < arr2.length; i++) {
        if (newArr.indexOf(arr2[i]) === -1) {
            newArr.push(arr2[i])    
        }
    }
    return newArr
}

let a1 = [2, 1, 4, 5, 3, 3]
let a2 = [2, 1, 6, 9, 3, 3]
let a3 = uniteArrs(a1, a2)
//showArray(a3)


// 8
function uniteArrs2(arr1, arr2) {    
    let newArr = new Array()
    for (let i = 0; i < arr1.length; i++) {
        if (arr2.indexOf(arr1[i]) !== -1 && newArr.indexOf(arr1[i]) === -1) {
            newArr.push(arr1[i])
        }
    }
    return newArr
}
a4 = uniteArrs2(a1, a2)
showArray(a4)

// 9
function uniteArrs3(arr1, arr2) {    
    let newArr = new Array()
    for (let i = 0; i < arr1.length; i++) {
        if (arr2.indexOf(arr1[i]) !== -1 && newArr.indexOf(arr1[i]) === -1) {
            newArr.push(arr1[i])
        }
    }
    return newArr
}
a5 = uniteArrs3(a1, a2)
showArray(a5)