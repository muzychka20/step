document.addEventListener('DOMContentLoaded', function() {
    var box = document.getElementById('resizeableBox');
    
    // Увеличиваем размер блока
    document.getElementById('increaseSize').addEventListener('click', function() {
        box.style.width = box.offsetWidth + 10 + 'px';
        box.style.height = box.offsetHeight + 10 + 'px';
    });

    // Сбрасываем размер блока к исходному
    document.getElementById('resetSize').addEventListener('click', function() {
        box.style.width = '100px';
        box.style.height = '100px';
    });

    // Уменьшаем размер блока
    document.getElementById('decreaseSize').addEventListener('click', function() {
        box.style.width = Math.max(box.offsetWidth - 10, 10) + 'px'; // Не меньше 10px
        box.style.height = Math.max(box.offsetHeight - 10, 10) + 'px'; // Не меньше 10px
    });
});

