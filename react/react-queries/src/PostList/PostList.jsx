export default function PostList({ posts }) {
  return (
    <>
      <h3>Posts</h3>
      <ul>
        {posts.map((post) => (
          <li key={post.id}>
            <h2>{post.title}</h2>
            <p>{post.body}</p>
          </li>
        ))}
      </ul>
    </>
  );
}
