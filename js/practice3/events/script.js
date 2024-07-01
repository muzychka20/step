document.addEventListener('DOMContentLoaded', function() {
    const inputField = document.getElementById('eventInput');
    const eventDisplay = document.getElementById('lastEvent');

    // Функция для обновления отображаемого текста события
    const updateEventDisplay = (event) => {
        eventDisplay.textContent = event.type;
    };

    // События мыши
    inputField.addEventListener('click', updateEventDisplay);
    inputField.addEventListener('dblclick', updateEventDisplay);
    inputField.addEventListener('mousemove', updateEventDisplay);
    inputField.addEventListener('mouseover', updateEventDisplay);
    inputField.addEventListener('mouseout', updateEventDisplay);

    // События клавиатуры
    inputField.addEventListener('keydown', updateEventDisplay);
    inputField.addEventListener('keypress', updateEventDisplay);
    inputField.addEventListener('keyup', updateEventDisplay);
});
