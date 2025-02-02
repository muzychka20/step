var socket = io();

socket.on('connect', function() {
    console.log("Connected to chat!");
});

socket.on('receive_message', function(data) {
    let messages = document.getElementById('messages');
    let message = document.createElement('div');
    message.innerHTML = `<b>${data.sender}:</b> ${data.text}`;
    messages.appendChild(message);
});

function sendMessage() {
    let input = document.getElementById('messageInput');
    if (input.value.trim() !== "") {
        socket.emit('send_message', {message: input.value});
        input.value = "";
    }
}