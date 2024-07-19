export default function ApplyButton() {
  
  function showAppliedAlert() {
    alert('Changes applied!')
  }

  return (
    <>
      <button onClick={showAppliedAlert} type="button" className="btn btn-success">Apply</button>
    </>
  )
}