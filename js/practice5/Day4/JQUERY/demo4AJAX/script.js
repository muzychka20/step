document.addEventListener('DOMContentLoaded', function() {
  document.getElementById('loadDataButton').addEventListener('click', function() {
    fetch('https://jsonplaceholder.typicode.com/posts/1')
      .then(response => response.json())
      .then(json => {
        document.getElementById('dataContainer').innerHTML = json.title;
      });
  });
});

  