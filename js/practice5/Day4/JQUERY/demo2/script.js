document.addEventListener('DOMContentLoaded', function() {
  // Кнопка делает текст красным
  document.getElementById('makeRed').addEventListener('click', function() {
      var specialText = document.getElementById('specialText');
      specialText.className = 'red-text';
  });

  // Кнопка убирает классы цвета
  document.getElementById('removeColor').addEventListener('click', function() {
      var specialText = document.getElementById('specialText');
      specialText.className = ''; // Удаляем все классы
  });

  // Кнопка делает текст синим
  document.getElementById('makeBlue').addEventListener('click', function() {
      var specialText = document.getElementById('specialText');
      specialText.className = 'blue-text';
  });
});
