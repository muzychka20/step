export default function EmailInput() {
  return (
    <div className="input-group">
      <span className="input-group-text">&#x40;</span>
      <input type="email" className="form-control" placeholder="Email" aria-label="Email" required/>
    </div>
  )
}