document.getElementById('xhrRequest').addEventListener('click', function() {
    var xhr = new XMLHttpRequest();
    // xhr.open("GET", "https://reqres.in/api/users/2");
    xhr.open('GET', 'https://reqres.in/api/users', false); // Третий параметр false указывает на синхронность запроса

    xhr.onreadystatechange = function() {
        if(xhr.readyState === 4) {
            console.log("XMLHttpRequest Response:", xhr.responseText);
        }
    };
    xhr.send();
});

// Fetch API
document.getElementById('fetchRequest').addEventListener('click', function() {
    fetch("https://reqres.in/api/users/2")
        .then(response => response.json())
        .then(data => console.log("Fetch API Response:", data))
        .catch(error => console.error('Fetch Error:', error));
});

// jQuery.ajax
document.getElementById('jqueryRequest').addEventListener('click', function() {
    $.ajax({
        url: "https://reqres.in/api/users/2",
        method: "GET"
    }).done(function(data) {
        console.log("jQuery.ajax Response:", data);
    }).fail(function(error) {
        console.error('jQuery.ajax Error:', error);
    });
});

// XMLHttpRequest с использованием прокси
document.getElementById('xhrProxyRequest').addEventListener('click', function() {
    var xhr = new XMLHttpRequest();
    var proxyUrl = 'https://cors-anywhere.herokuapp.com/'; // Используйте ваш собственный proxy в продакшн
    var targetUrl = 'https://reqres.in/api/users/2';
    xhr.open("GET", proxyUrl + targetUrl);
    xhr.onreadystatechange = function() {
        if(xhr.readyState === 4) {
            console.log("XMLHttpRequest with Proxy Response:", xhr.responseText);
        }
    };
    xhr.send();
});