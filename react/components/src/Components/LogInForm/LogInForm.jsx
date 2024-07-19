import EmailInput from "../EmailInput/EmailInput";
import LogInButton from "../LogInButton/LogInButton";
import PasswordInput from "../PasswordInput/PasswordInput";
import "./LogInForm.css"

export default function LogInForm() {
  return (    
      <form className="container-fluid">        
        <EmailInput/>
        <PasswordInput/>
        <LogInButton/>
      </form>
  )
}