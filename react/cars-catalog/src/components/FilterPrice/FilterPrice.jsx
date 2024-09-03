import "./FilterPrice.css"

export default function FilterPrice({minPrice, setMinPrice, maxPrice, setMaxPrice}) {
    return (
        <div className="filterPanelPrice">
            <label htmlFor="minPrice">Min Price</label>
            <input className="input_filter" type="number" id="minPrice" placeholder="Min" value={minPrice} onChange={(event) => setMinPrice(event.target.value)}/>
            <label htmlFor="maxPrice">Max Price</label>
            <input className="input_filter" type="number" id="maxPrice" placeholder="Max" value={maxPrice} onChange={(event) => setMaxPrice(event.target.value)}/>
        </div>
    );
}