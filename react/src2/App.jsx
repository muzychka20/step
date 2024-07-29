import React, { useState, useEffect } from 'react';
import axios from 'axios';

function App() {
  const [posts, setPosts] = useState([]);
  const [title, setTitle] = useState('');
  const [body, setBody] = useState('');

  useEffect(() => {
    axios.get('https://jsonplaceholder.typicode.com/posts')
      .then(response => {
        setPosts(response.data);
      })
      .catch(error => {
        console.error('There was an error fetching the data!', error);
      });
  }, []);

  const handleSubmit = (e) => {
    e.preventDefault();
    const newPost = {
      title: title,
      body: body,
      userId: 1
    };
    axios.post('https://jsonplaceholder.typicode.com/posts', newPost)
      .then(response => {
        setPosts([response.data, ...posts]);
        setTitle('');
        setBody('');
      })
      .catch(error => {
        console.error('There was an error creating the post!', error);
      });
  };

  return (
    <div className="App">
      <h1>Posts</h1>
      <form onSubmit={handleSubmit}>
        <div>
          <label>Title</label>
          <input 
            type="text" 
            value={title} 
            onChange={(e) => setTitle(e.target.value)} 
          />
        </div>
        <div>
          <label>Body</label>
          <textarea 
            value={body} 
            onChange={(e) => setBody(e.target.value)} 
          />
        </div>
        <button type="submit">Create Post</button>
      </form>
      <ul>
        {posts.map(post => (
          <li key={post.id}>
            <h2>{post.title}</h2>
            <p>{post.body}</p>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;
