import { useState } from "react";
import "./CarAdd.css";
import DragDrop from "../DragDrop/DragDrop";
import { v4 as uuidv4 } from "uuid"; // Import uuid for unique ids

export default function CarAdd({ onAddCar }) {
  const [carDetails, setCarDetails] = useState({
    id: "",
    name: "",
    manufacturer: "",
    year: "",
    color: "",
    volume: "",
    price: "",
    description: "",
    imageUrl: "", // Will hold the file path instead of a URL
  });

  const handleChange = (e) => {
    const { name, value } = e.target;
    setCarDetails((prevDetails) => ({
      ...prevDetails,
      [name]: value,
    }));
  };

  const handleFileUpload = (filePath) => {
    setCarDetails((prevDetails) => ({
      ...prevDetails,
      imageUrl: filePath, // Update the imageUrl with the uploaded file path
    }));
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    const newCar = { ...carDetails, id: uuidv4() };
    onAddCar(newCar);
    setCarDetails({
      id: "",
      name: "",
      manufacturer: "",
      year: "",
      color: "",
      volume: "",
      price: "",
      description: "",
      imageUrl: "",
    });
  };

  return (
    <div>
      <h2>Create new car</h2>
      <form className="form" onSubmit={handleSubmit}>
        <input
          className="input"
          type="text"
          name="name"
          placeholder="Name"
          value={carDetails.name}
          onChange={handleChange}
        />
        <input
          className="input"
          type="text"
          name="manufacturer"
          placeholder="Manufacturer"
          value={carDetails.manufacturer}
          onChange={handleChange}
        />
        <input
          className="input"
          type="text"
          name="year"
          placeholder="Year of manufacture"
          value={carDetails.year}
          onChange={handleChange}
        />
        <input
          className="input"
          type="text"
          name="color"
          placeholder="Color"
          value={carDetails.color}
          onChange={handleChange}
        />
        <input
          className="input"
          type="text"
          name="volume"
          placeholder="Volume"
          value={carDetails.volume}
          onChange={handleChange}
        />
        <input
          className="input"
          type="text"
          name="price"
          placeholder="Price"
          value={carDetails.price}
          onChange={handleChange}
        />
        <textarea
          className="input"
          name="description"
          placeholder="Description"
          value={carDetails.description}
          onChange={handleChange}
        />
        <DragDrop onFileUpload={handleFileUpload} /> {/* Pass handleFileUpload to DragDrop */}
        <button className="btn" type="submit">
          Create
        </button>
      </form>
    </div>
  );
}
