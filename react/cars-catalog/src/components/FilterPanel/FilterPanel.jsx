import React from 'react';
import FilterPrice from "../FilterPrice/FilterPrice";
import Input from "../Input/Input";
import './FilterPanel.css'; // Import the CSS file for styles

export default function FilterPanel({
    type,
    setTypeFilter,
    typeFilterValue,
    setTypeFilterValue,
    minPrice,
    maxPrice,
    setMinPrice,
    setMaxPrice
}) {
    const filterOptions = ["manufacturer", "year", "color", "volume", "price", "none"];

    const handleChange = (event) => {
        const selectedType = event.target.value;
        setTypeFilter(selectedType);
    };

    return (
        <div className="filterPanel">
            <select value={type} onChange={handleChange} className="filterSelect">
                {filterOptions.map((option, index) => (
                    <option key={index} value={option}>
                        {option}
                    </option>
                ))}
            </select>
            {type === "price" && (
                <FilterPrice
                    minPrice={minPrice}
                    maxPrice={maxPrice}
                    setMinPrice={setMinPrice}
                    setMaxPrice={setMaxPrice}
                />
            )}
            {(type !== "price" && type && type !== "none") && (
                <Input
                    typeFilterValue={typeFilterValue}
                    setTypeFilterValue={setTypeFilterValue}
                />
            )}
            {type === "none" && (
                <div className="filterOptions">
                    <Input
                        typeFilterValue={typeFilterValue}
                        setTypeFilterValue={setTypeFilterValue}
                    />
                    <FilterPrice
                        minPrice={minPrice}
                        maxPrice={maxPrice}
                        setMinPrice={setMinPrice}
                        setMaxPrice={setMaxPrice}
                    />                    
                </div>
            )}
        </div>
    );
}
