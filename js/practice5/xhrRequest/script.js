button = document.getElementById('requestGetButton1')
button.addEventListener('click', function() {
    let xhr = new XMLHttpRequest()
    xhr.open('GET', 'https://reqres.in/api/{resource}/6', false)

    xhr.onreadystatechange = function() {
        if (xhr.readyState === 4) {
            console.log("XMLHttpRequest Response:", xhr.responseText)
        }
    }
    xhr.send()
})

button2 = document.getElementById('requestGetButton2')
button2.addEventListener('click', function() {
    fetch('https://reqres.in/api/{resource}')
        .then(response => response.json())
        .then(data => console.log("Data: ", data))
        .catch(error => console.log("Error: ", error))
})