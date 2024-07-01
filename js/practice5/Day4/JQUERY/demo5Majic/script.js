document.addEventListener('DOMContentLoaded', function() {
  document.getElementById('magicButton').addEventListener('click', function() {
    var importantParagraphs = document.querySelectorAll('.important');
    importantParagraphs.forEach(function(p) {
      p.style.display = 'none';
      p.textContent = 'Обновленный важный текст';
      setTimeout(function() {
        p.style.display = 'block';
      }, 500);
    });
  });
});
