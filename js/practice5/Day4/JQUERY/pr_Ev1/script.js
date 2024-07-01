$(document).ready(function() {
  // Событие 'click' для кнопки
  $('#btnClickMe').click(function() {
      alert('Кнопка была нажата!');
  });

  // Событие 'focus' и 'blur' для текстового поля
  $('#inputText').focus(function() {
      $(this).css('background-color', 'lightyellow');
  }).blur(function() {
      $(this).css('background-color', 'white');
  });

  // События 'mouseenter' и 'mouseleave' для элементов списка
  $('#hoverList li').mouseenter(function() {
      $(this).css('color', 'red');
  }).mouseleave(function() {
      $(this).css('color', 'black');
  });
});
