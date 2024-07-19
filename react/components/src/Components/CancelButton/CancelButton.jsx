export default function CancelButton() {
  
  function showCanceledAlert() {
    alert('The operation canceled!')
  }

  return (
    <>
      <button onClick={showCanceledAlert} type="button" className="btn btn-danger">Cancel</button>
    </>
  )
}