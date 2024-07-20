import { useState, useRef } from "react";
import Button from "../Button/Button";

function StateVsRef() {
  const input = useRef();
  const [show, setShow] = useState(false);

  function handleKeyDown(event) {
    if (event.key === "Enter") {
      setShow(true)
    }
  }

  return (
    <div>
      <h3>Input value: {show && input.current.value}</h3>
      <input
        ref={input}
        type="text"
        className="control"
        onKeyDown={handleKeyDown}
      />
    </div>
  );
}

export default function FeedbackSection() {
  const [form, setForm] = useState({
    name: "",
    reason: "help",
    hasError: false,
  });

  // const [name, setName] = useState("");
  // const [reason, setReason] = useState("help");
  // const [hasError, setHasError] = useState(false);

  function handleChangeName(event) {
    setForm((prev) => ({
      ...prev,
      name: event.target.value,
      hasError: event.target.value.trim().length === 0,
    }));
  }

  function toggleError() {
    setForm((prev) => ({ ...prev, hasError: !prev.hasError }));
  }

  return (
    <section>
      <h3>Feedback</h3>

      <Button onClick={toggleError}>Toggle error</Button>

      <form style={{ marginBottom: "1rem" }}>
        <label htmlFor="name">Your name</label>
        <input
          type="text"
          id="name"
          className="control"
          value={form.name}
          onChange={handleChangeName}
          style={{
            border: form.hasError ? "1px solid red" : null,
          }}
        />

        <label htmlFor="reason">Your reason</label>
        <select
          id="reason"
          className="control"
          value={form.reason}
          onChange={(event) => {
            setForm((prev) => ({ ...prev, reason: event.target.value }));
          }}
        >
          <option value="error">Error</option>
          <option value="help">Need help</option>
          <option value="suggest">Suggest</option>
        </select>

        <Button disabled={form.hasError} isActive={!form.hasError}>
          Submit
        </Button>

        <pre>{JSON.stringify(form, null, 2)}</pre>
      </form>
      <hr />
      <StateVsRef />
    </section>
  );
}
