import { useEffect, useState } from "react";
import Car from "../Car/Car";
import FilterPanel from "../FilterPanel/FilterPanel";
import "./CarList.css";

export default function CarList({ cars }) {
  const [filteredCars, setFilteredCars] = useState(cars);
  const [typeFilter, setTypeFilter] = useState();
  const [typeFilterValue, setTypeFilterValue] = useState("2020");
  const [minPrice, setMinPrice] = useState(0);
  const [maxPrice, setMaxPrice] = useState(999999);

  useEffect(() => {
    if (typeFilter === "price") {
      setFilteredCars(
        cars.filter(
          (car) =>
            parseInt(car.price) <= parseInt(maxPrice) &&
            parseInt(car.price) >= parseInt(minPrice)
        )
      );
    } else if (typeFilter === "none") {
      setFilteredCars(cars);
    } else if (typeFilter) {
      setFilteredCars(cars.filter((car) => car[typeFilter]?.toString() === typeFilterValue));
    } else {
      setFilteredCars(cars);
    }
  }, [typeFilter, typeFilterValue, cars, minPrice, maxPrice]);

  return (
    <>
      <FilterPanel
        type={typeFilter}
        setTypeFilter={setTypeFilter}
        typeFilterValue={typeFilterValue}
        setTypeFilterValue={setTypeFilterValue}
        minPrice={minPrice}
        maxPrice={maxPrice}
        setMinPrice={setMinPrice}
        setMaxPrice={setMaxPrice}
      />
      <ol>
        {filteredCars.map((car) => (
          <li key={car.id}>
            <Car car={car} />
          </li>
        ))}
      </ol>
    </>
  );
}
