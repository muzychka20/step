import PostList from "../PostList/PostList";
import { useState } from "react";
import axios from "axios";

export default function CommentForm({ onSubmit }) {
  const [name, setName] = useState("");
  const [email, setEmail] = useState("");
  const [body, setBody] = useState("");

  const handleSubmit = (e) => {
    e.preventDefault();
    onSubmit({ name, email, body });
    setName("");
    setEmail("");
    setBody("");
  };

  return (
    <>
      <form onSubmit={handleSubmit}>
        <h1>Comments</h1>
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
          <textarea value={email} onChange={(e) => setEmail(e.target.value)} />
        </div>
        <div>
          <label>Body</label>
          <textarea value={body} onChange={(e) => setBody(e.target.value)} />
        </div>
        <button type="submit">Create Comment</button>
      </form>      
    </>
  );
}
