import "./Input.css"

export default function Input({typeFilterValue, setTypeFilterValue}) {
    return (
        <div>
            <input className="input_filter" type="text"
            placeholder="Enter a car..."
            value={typeFilterValue}
            onChange={(event)=> {setTypeFilterValue(event.target.value)}}/>
        </div>
    );
}