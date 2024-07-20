import WayToTeach from "../WayToTeach/WayToTeach";
import { ways } from "../../data";

export default function TeachingSection() {
  return (
    <section>
      <h1>Hello React</h1>
      <ul>
        {ways.map((way) => (
          <WayToTeach key={way.title} {...way} />
        ))}
      </ul>
    </section>
  );
}
