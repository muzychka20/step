$(document).mousemove(function(event) {
  var circle = $('#circle');
  var circleWidth = circle.width();
  var circleHeight = circle.height();
  var screenWidth = $(window).width();
  var screenHeight = $(window).height();

  // Рассчитываем новые координаты для круга
  var newX = event.pageX - circleWidth / 2;
  var newY = event.pageY - circleHeight / 2;

  // Проверяем, чтобы круг не выходил за пределы экрана
  newX = Math.max(0, Math.min(newX, screenWidth - circleWidth));
  newY = Math.max(0, Math.min(newY, screenHeight - circleHeight));

  // Перемещаем круг
  circle.css({'left': newX + 'px', 'top': newY + 'px'});
});
