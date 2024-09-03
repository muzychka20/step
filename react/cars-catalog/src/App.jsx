import { useState } from "react";
import "./App.css";
import CarList from "./components/CarList/CarList";
import { automobiles } from "../CarArray";
import CarAdd from "./components/CarAdd/CarAdd";

function App() {
  const [cars, setCars] = useState(automobiles);
  const [page, setPage] = useState("list");

  const addCar = (newCar) => {
    // Check if all fields are filled
    const allFieldsFilled = Object.values(newCar).every(
      (value) => value.trim() !== ""
    );

    if (allFieldsFilled) {
      setCars([...cars, newCar]);
      setPage("list"); // Switch back to list view after adding a car
    } else {
      alert("Please fill out all fields.");
    }
  };

  const handlePageChange = (newPage) => {
    setPage(newPage);
  };

  return (
    <div>
      <nav>
        <button onClick={() => handlePageChange("list")}>View List</button>
        <button onClick={() => handlePageChange("form")}>Add New Car</button>
      </nav>
      {page === "form" && <CarAdd onAddCar={addCar} />}
      {page === "list" && <CarList cars={cars} />}
    </div>
  );
}

export default App;
