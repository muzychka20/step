$(document).ready(function() {
  $('#loadDataButton').click(function() {
    $.ajax({
      url: 'https://jsonplaceholder.typicode.com/posts/1',
      type: 'GET',
      success: function(result) {
        $('#dataContainer').html(result.title);
      }
    });
  });
});
