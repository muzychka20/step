import "./Car.css";

export default function Car({ carKey, car }) {
  return (
    <div className="car-container">
      <h1>{`${car.name} ${car.manufacturer}`}</h1>
      <p>{`Year: ${car.year}`}</p>
      <p>{`Color: ${car.color}`}</p>
      <p>{`Volume: ${car.volume}`}</p>
      <p>{`Price: ${car.price}`}</p>
      <p>{`Description: ${car.description}`}</p>
      <img src={car.imageUrl} alt={car.name} />
    </div>
  );
}
