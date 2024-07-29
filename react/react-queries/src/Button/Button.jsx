export default function Button({ children, buttonClicked }) {
  return <button onClick={buttonClicked}>{children}</button>;
}
