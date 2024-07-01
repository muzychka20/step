// document.addEventListener('DOMContentLoaded', function() {
//   const stars = document.querySelectorAll('.star');
  
//   stars.forEach(star => {
//       star.addEventListener('click', function() {
//           const value = this.getAttribute('data-value');
//           highlightStars(value);
//       });
//   });

//   function highlightStars(value) {
//       stars.forEach(star => {
//           star.classList.remove('rated');
//           if (star.getAttribute('data-value') <= value) {
//               star.classList.add('rated');
//           }
//       });
//   }
// });

$(document).ready(function() {
  // Встановлюємо обробник подій кліку для всіх зірочок
  $('.star').click(function() {
      // Отримуємо значення оцінки з атрибуту data-value
      const value = $(this).data('value');
      highlightStars(value);
  });

  function highlightStars(value) {
      // Видаляємо клас 'rated' у всіх зірочок
      $('.star').removeClass('rated');
      // Додаємо клас 'rated' до зірочок, чий data-value менший або рівний заданому значенню
      $('.star').each(function() {
          if ($(this).data('value') <= value) {
              $(this).addClass('rated');
          }
      });
  }
});
