export default function Button() {   
    const handleClick = () => {
        console.log("Button has been clicked!")
    }
    return (
       <div>
        <button onClick={handleClick}>Click</button>
       </div>
    )
}