// Дожидаемся полной загрузки DOM.
document.addEventListener('DOMContentLoaded', function() {
  // При клике на кнопку с ID 'addItem' выполняем функцию.
  document.getElementById('addItem').addEventListener('click', function() {
    // Создаем новый элемент списка <li>.
    var newItem = document.createElement('li');
    // Устанавливаем текстовое содержимое нового элемента.
    newItem.textContent = 'Новый пункт';
    // Добавляем новый элемент в конец списка <ul> с ID 'myList'.
    document.getElementById('myList').appendChild(newItem);
    // Анимация: плавно изменяем прозрачность нового элемента от 0 до 1.
    newItem.style.opacity = 0;
    var opacity = 0;
    var intervalID = setInterval(function() {
      if (opacity < 1) {
        opacity += 0.1;
        newItem.style.opacity = opacity;
      } else {
        clearInterval(intervalID);
      }
    }, 50);
  });
});
