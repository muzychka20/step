import React, { useState, useEffect } from 'react';
import axios from 'axios';
import PostList from './PostList';
import PostForm from './PostForm';
import './App.css'
import SinglePost from './SinglePost';

function App() {
  const [posts, setPosts] = useState([]);

  // useEffect(() => {
  //   axios.get('https://jsonplaceholder.typicode.com/posts')
  //     .then(response => {
  //       setPosts(response.data);
  //     })
  //     .catch(error => {
  //       console.error('There was an error fetching the data!', error);
  //     });
  // }, []);

  const fetchAllPosts = () => {
    axios.get('https://jsonplaceholder.typicode.com/posts')
      .then(response => {
        setPosts(post, response.data);
      })
      .catch(error => {
        console.error('There was an error fetching the data!', error);
      });
  };

  const addPost = (newPost) => {
    axios.post('https://jsonplaceholder.typicode.com/posts', newPost)
      .then(response => {
        setPosts([response.data, ...posts]);
      })
      .catch(error => {
        console.error('There was an error creating the post!', error);
      });
  };

  return (
    <div className="App">
      <h1>Posts</h1>
      <button onClick={fetchAllPosts}>Fetch All Posts</button>
      <PostForm onSubmit={addPost} />
      <PostList posts={posts} />
      <h1>Single Post</h1>
      <SinglePost />
    </div>
  );
}

export default App;
