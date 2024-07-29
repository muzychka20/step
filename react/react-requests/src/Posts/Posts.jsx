import { useState, useEffect } from 'react'
import axios from 'axios'
import Post from '../Post/Post';

export default function Posts() {
    const [posts, setPosts] = useState([]);

    useEffect(() => {
      axios.get('https://jsonplaceholder.typicode.com/posts')
        .then(response => {
          setPosts(response.data);
        })
        .catch(error => {
          console.error('There was an error fetching the data!', error);
        });
    }, []);

    return (
      <div className="App">
        <h1>Posts</h1>
        <ul>
          {posts.map(post => (
            <Post post={post}/>
          ))}
        </ul>
      </div>
    );
}