// $(document).ready(function() {
//   $('#menuHeader').click(function() {
//       $('#menuContent').slideToggle();
//   });
// });

document.addEventListener('DOMContentLoaded', function() {
  var menuHeader = document.getElementById('menuHeader');
  var menuItems = document.getElementById('menuContent');

  menuHeader.addEventListener('click', function() {
      // Проверяем, отображается ли в данный момент меню
      if (menuItems.style.display === 'none') {
          // Если меню скрыто, показываем его
          menuItems.style.display = 'block';
      } else {
          // Если меню видно, скрываем его
          menuItems.style.display = 'none';
      }
  });
});
