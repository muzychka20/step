import AgreeCheckbox from "../AgreeCheckbox/AgreeCheckbox";
import ApplyButton from "../ApplyButton/ApplyButton";
import CancelButton from "../CancelButton/CancelButton";
import "./ConfirmationCard.css"

export default function ConfirmationCard() {
  return (    
    <div className="card">
      <div className="card-header">
        Bargain
      </div>
      <div className="card-body">        
        <h5 className="card-title">Special offer</h5>
        <p className="card-text">Opening a new store location? That's a big deal – and the perfect opportunity to get your SMS subscribers excited and engaged. Use personalization, exclusive offers, and a sense of urgency to drive that foot traffic and create buzz around your new location. </p>
        <AgreeCheckbox/>
        <div className="card-buttons">
          <CancelButton/>
          <ApplyButton/>
        </div>
      </div>
  </div>
  )
}