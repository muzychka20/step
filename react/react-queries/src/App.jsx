import { useState, useEffect } from "react";
import "./App.css";
import axios from "axios";
import PostList from "./PostList/PostList";
import CommentList from "./CommentList/CommentList";
import Button from "./Button/Button";
import PostForm from "./PostForm/PostForm";
import CommentForm from "./CommentForm/CommentForm";
import { fetchAllPosts, fetchAllComments, addComment, addPost } from "../api";

function App() {
  const [isActive, setIsActive] = useState(false);
  const [posts, setPosts] = useState([]);
  const [comments, setComments] = useState([]);

  async function getPosts() {
    try {
      setIsActive(true);
      setPosts(await fetchAllPosts());
    } catch (err) {
      console.error(err);
    }
  }

  async function getComments() {
    try {
      setIsActive(false);
      setComments(await fetchAllComments());
    } catch (err) {
      console.error(err);
    }
  }

  async function setPost(newPost) {
    const data = await addPost(newPost);
    setPosts([data, ...posts]);
  }

  async function setComment(newComment) {
    const data = await addComment(newComment);
    setComments([data, ...comments]);
  }

  return (
    <>
      <Button
        buttonClicked={() => {
          getPosts();
        }}
      >
        Get Posts
      </Button>

      <Button
        buttonClicked={() => {
          getComments();
        }}
      >
        Get Comments
      </Button>

      <PostForm onSubmit={setPost} />
      <CommentForm onSubmit={setComment} />

      {isActive && <PostList posts={posts} />}
      {!isActive && <CommentList comments={comments} />}
    </>
  );
}

export default App;
