$(document).ready(function() {
  // Кнопка делает текст красным
  $('#makeRed').click(function() {
      $('#specialText').removeClass('blue-text').addClass('red-text');
  });

  // Кнопка убирает классы цвета
  $('#removeColor').click(function() {
      $('#specialText').removeClass('red-text blue-text');
  });

  // Кнопка делает текст синим
  $('#makeBlue').click(function() {
      $('#specialText').removeClass('red-text').addClass('blue-text');
  });
});
