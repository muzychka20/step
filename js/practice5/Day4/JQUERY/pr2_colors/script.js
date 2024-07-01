
$(document).ready(function() {
  $('.filter-button').click(function() {
      const color = $(this).data('color');
      $('.fruits-list li').each(function() {
          if ($(this).data('color') === color) {
              $(this).addClass('highlight');
          } else {
              $(this).removeClass('highlight');
          }
      });
  });
});
