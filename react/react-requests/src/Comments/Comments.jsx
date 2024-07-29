import { useState, useEffect } from 'react'
import axios from 'axios'

export default function Comments() {
    const [comments, setComments] = useState([]);

    useEffect(() => {
      axios.get(' https://jsonplaceholder.typicode.com/comments')
        .then(response => {
          setComments(response.data);
        })
        .catch(error => {
          console.error('There was an error fetching the data!', error);
        });
    }, []);


    return (
      <div className="App">
        <h1>Comments</h1>
        <ul>
          {comments.map(comment => (
            <li key={comment.id}>
              <h2>{comment.name}</h2>
              <p>{comment.body}</p>
            </li> 
          ))}
        </ul>
      </div>
    );
}