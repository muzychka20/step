export default function CommentList({ comments }) {
  return (
    <>
      <h3>Comments</h3>
      <ul>
        {comments.map((comment) => (
          <li key={comment.id}>
            <h2>{comment.name}</h2>
            <p>{comment.email}</p>
            <p>{comment.body}</p>
          </li>
        ))}
      </ul>
    </>
  );
}
