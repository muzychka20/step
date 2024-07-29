import './App.css'
import Comments from './Comments/Comments'
import Posts from './Posts/Posts'
import React, { useState, useEffect } from 'react';
import axios from 'axios';

function App() {
  const [comments, setComments] = useState([]);
  const [name, setName] = useState('');
  const [email, setEmail] = useState('');
  const [body, setBody] = useState('');

  useEffect(() => {
    axios.get('https://jsonplaceholder.typicode.com/comments')
      .then(response => {
        setComments(response.data);
      })
      .catch(error => {
        console.error('There was an error fetching the data!', error);
      });
  }, []);

  const handleSubmit = (e) => {
    e.preventDefault();
    const newComment = {
      name: name,
      email: email,
      body: body,
      postId: 1
    };
    axios.post('https://jsonplaceholder.typicode.com/comments', newComment)
      .then(response => {
        setComments([response.data, ...comments]);
        setName('');
        setEmail('');
        setBody('');
      })
      .catch(error => {
        console.error('There was an error creating the post!', error);
      });
  };

  return (
    <>
      {/* <Posts />
      <Comments /> */}
      <div className="App">
        <h1>Comments</h1>
        <form onSubmit={handleSubmit}>
          <div>
            <label>Name</label>
            <input 
              type="text" 
              value={name} 
              onChange={(e) => setName(e.target.value)} 
            />
          </div>
          <div>
            <label>Email</label>
            <textarea 
              value={email} 
              onChange={(e) => setEmail(e.target.value)} 
            />
          </div>
          <div>
            <label>Body</label>
            <textarea 
              value={body} 
              onChange={(e) => setBody(e.target.value)} 
            />
          </div>
          <button type="submit">Create Comment</button>
        </form>
        <ul>
          {comments.map(comment => (
            <li key={comment.id}>
              <h2>{comment.name}</h2>
              <p>{comment.email}</p>
              <p>{comment.body}</p>
            </li>
          ))}
        </ul>
      </div>
    </>
  )
}

export default App
