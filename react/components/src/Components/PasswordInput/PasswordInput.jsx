import "./PasswordInput.css"

export default function PasswordInput() {
  return (    
    <div className="input-group">
      <span className="input-group-text fas fa-key"></span>
      <input type="password" className="form-control" placeholder="Password" aria-label="Password" required/>
    </div>   
  )
}