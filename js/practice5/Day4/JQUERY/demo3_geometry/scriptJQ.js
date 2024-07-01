$(document).ready(function() {
    var $box = $('#resizeableBox');
    
    // Увеличиваем размер блока
    $('#increaseSize').click(function() {
        $box.width($box.width() + 10);
        $box.height($box.height() + 10);
    });

    // Сбрасываем размер блока к исходному
    $('#resetSize').click(function() {
        $box.width(100);
        $box.height(100);
    });

    // Уменьшаем размер блока
    $('#decreaseSize').click(function() {
        $box.width(Math.max($box.width() - 10, 10)); // Не меньше 10px
        $box.height(Math.max($box.height() - 10, 10)); // Не меньше 10px
    });
});

