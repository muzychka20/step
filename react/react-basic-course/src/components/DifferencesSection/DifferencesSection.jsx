import Button from "../Button/Button";
import { differences } from "../../data";
import { useState } from "react";

export default function DifferencesSection() {
  const [contentType, setContentType] = useState(null);

  function handleClick(type) {
    console.log("Button clicked " + type);
    setContentType(type);
  }

  return (
    <section>
      <h3>What the difference? props/children</h3>
      <Button
        isActive={contentType === "way"}
        onClick={() => handleClick("way")}
      >
        Button1
      </Button>
      <Button
        isActive={contentType === "easy"}
        onClick={() => handleClick("easy")}
      >
        Button2
      </Button>
      <Button
        isActive={contentType === "program"}
        onClick={() => handleClick("program")}
      >
        Button3
      </Button>

      {/* 1 */}
      {contentType ? (
        <p>{differences[contentType]}</p>
      ) : (
        <p>Press on the button</p>
      )}

      {/* 2 */}
      {!contentType && <p>Press on the button</p>}
      {contentType && <p>{differences[contentType]}</p>}
    </section>
  );
}
