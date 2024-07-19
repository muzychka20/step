import './AgreeCheckbox.css'

export default function AgreeCheckbox() {
  return (
    <div className="inputChecboxBlock">
      <input className="form-check-input" type="checkbox" id="checkboxAgree"/>
      <label hrmlfor="checkboxAgree">Get messages and news</label>
    </div>        
  )
}