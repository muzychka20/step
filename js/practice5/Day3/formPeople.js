document.getElementById('getUsers').addEventListener('click', function() {
    fetch('https://reqres.in/api/users')
      .then(response => response.json())
      .then(data => {
        document.getElementById('response').innerHTML = `<pre>${JSON.stringify(data, null, 2)}</pre>`;
      });
  });
  
  document.getElementById('getUserForm').addEventListener('submit', function(e) {
    e.preventDefault();
    const userId = document.getElementById('userId').value;
    fetch(`https://reqres.in/api/users/${userId}`)
      .then(response => response.json())
      .then(data => {
        document.getElementById('response').innerHTML = `<pre>${JSON.stringify(data, null, 2)}</pre>`;
      });
  });
  
  document.getElementById('createUserForm').addEventListener('submit', function(e) {
    e.preventDefault();
    const userName = document.getElementById('userName').value;
    const userJob = document.getElementById('userJob').value;
  
    fetch('https://reqres.in/api/users', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify({
        name: userName,
        job: userJob
      })
    })
    .then(response => response.json())
    .then(data => {
      document.getElementById('response').innerHTML = `<pre>${JSON.stringify(data, null, 2)}</pre>`;
    });
  });
  