$(document).ready(function() {
  // Поиск элемента по идентификатору
  var uniqueBox = $('#uniqueBox');
  console.log('Элемент с ID "uniqueBox":', uniqueBox);

  // Поиск элементов по классу
  var specialElements = $('.special');
  console.log('Элементы с классом "special":', specialElements);

  // Поиск всех ссылок
  var links = $('a');
  console.log('Все ссылки на странице:', links);

  // Поиск элементов по селектору - элементы списка внутри #list
  var items = $('#list .item');
  console.log('Все элементы списка внутри #list:', items);

  // Изменение стилей найденного элемента
  uniqueBox.css('background-color', 'lightblue');

  // Применение стилей к группе элементов
  specialElements.css('color', 'red');
});
