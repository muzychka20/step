document.getElementById('button1').addEventListener('click', () => {
    let xhr = new XMLHttpRequest()
    xhr.open('GET', 'https://petstore.swagger.io/v2/pet/5', false)
    xhr.onreadystatechange = () => {
        if (xhr.readyState === 4) {
            console.log("Response: ", xhr.responseText)
        }
    }
    xhr.send()
})

document.getElementById('button2').addEventListener('click', () => {
    fetch('https://petstore.swagger.io/v2/store/order/8')
        .then(response => response.json())
        .then(data => console.log("Data:", data))
        .catch(e => console.log("Error:", e))
})