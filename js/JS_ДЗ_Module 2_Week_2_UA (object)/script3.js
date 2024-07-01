let auditoriums = [
    {
        name: "B",
        capacity: 15,
        faculty: "Engineering"
    },
    {
        name: "C",
        capacity: 20,
        faculty: "Mathematics"
    },
    {
        name: "A2",
        capacity: 10,
        faculty: "Physics"
    },
    {
        name: "A1",
        capacity: 18,
        faculty: "Physics"
    },
    {
        name: "D",
        capacity: 12,
        faculty: "Engineering"
    },
    {
        name: "F",
        capacity: 17,
        faculty: "Mathematics"
    }
]


function showAllAuditoriums(arr) {
    for (let i in arr) {
        console.log(`${arr[i].name}: ${arr[i].capacity} - ${arr[i].faculty}`)
    }
}


function showAllAuditoriumsForFaculty(arr, facultyName) {
    arr.forEach(item => {
        if (item.faculty === facultyName) {
            console.log(`${item.name}: ${item.capacity} - ${item.faculty}`)
        }
    })
}


function orderByCapacity(arr) {
    arr.sort((a, b) => a.capacity - b.capacity)
}


function orderByName(arr) {    
    arr.sort((a, b) => a.name.toLowerCase() > b.name.toLowerCase() ? 1 : -1)
}


function getAuditoriums(arr, quantity, faculty) {
    return arr.filter(item => item.faculty === faculty && quantity <= item.capacity)
}


// showAllAuditoriums(auditoriums)
// showAllAuditoriumsForFaculty(auditoriums, "Engineering")

// orderByCapacity(auditoriums)
// showAllAuditoriums(auditoriums)


// orderByName(auditoriums)
// showAllAuditoriums(auditoriums)

group = prompt("Enter the group (name, quantity, faculty): ").split(', ')
showAllAuditoriums(getAuditoriums(auditoriums, parseInt(group[1]), group[2]))