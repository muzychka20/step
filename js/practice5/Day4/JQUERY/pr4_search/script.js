document.addEventListener('DOMContentLoaded', function() {
  // Поиск элемента по идентификатору
  var uniqueBox = document.getElementById('uniqueBox');
  console.log('Элемент с ID "uniqueBox":', uniqueBox);

  // Поиск элементов по имени класса
  var specialElements = document.getElementsByClassName('special');
  console.log('Элементы с классом "special":', specialElements);

  // Поиск элементов по тегу
  var links = document.getElementsByTagName('a');
  console.log('Все ссылки на странице:', links);

  // Поиск элементов по CSS-селектору
  var items = document.querySelectorAll('#list .item');
  console.log('Все элементы списка внутри #list:', items);

  // Поиск первого элемента по CSS-селектору
  var firstSpecial = document.querySelector('.special');
  console.log('Первый элемент с классом "special":', firstSpecial);

  // Изменение стилей найденного элемента
  if (uniqueBox) {
      uniqueBox.style.backgroundColor = 'lightblue';
  }

  // Применение стилей к группе элементов
  if (specialElements.length > 0) {
      Array.from(specialElements).forEach(function(element) {
          element.style.color = 'red';
      });
  }
});

