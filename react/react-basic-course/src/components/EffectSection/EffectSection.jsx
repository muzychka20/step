import { useState, useEffect, useCallback } from "react";
import Button from "../Button/Button";
import Modal from "../Modal/Modal";
import useInput from "../../hooks/useInput";

export default function EffectSection() {
  const input = useInput();
  const [modal, setModal] = useState(false);
  const [loading, setLoading] = useState(false);
  const [users, setUsers] = useState([]);

  const fetchUsers = useCallback(async () => {
    setLoading(true);
    const response = await fetch("https://jsonplaceholder.typicode.com/users");
    const users_data = await response.json();
    setUsers(users_data);
    setLoading(false);
  }, []);

  useEffect(() => {
    fetchUsers();
  }, [fetchUsers]);

  return (
    <section>
      <h3>Effects</h3>
      <Button
        style={{ marginBottom: "1rem" }}
        onClick={() => {
          setModal(true);
        }}
      >
        Open info
      </Button>
      <Modal open={modal}>
        <h3>Hello from modal</h3>
        <p>
          Lorem ipsum dolor sit amet consectetur adipisicing elit. Ipsam
          voluptatum ipsum suscipit saepe unde facilis ad officiis fugiat ipsa
          odio ut, recusandae omnis ab at iste nobis sint, vitae tempore.
        </p>
        <Button onClick={() => setModal(false)}>Close modal</Button>
      </Modal>

      {loading && <p>Loading...</p>}

      {!loading && (
        <>
          <input type="text" className="control" {...input} />
          <h6 style={{ marginBottom: "1rem" }}>Filter: {input.value}</h6>
          <ul>
            {users
              .filter((user) =>
                user.name
                  .toLowerCase()
                  .includes(input.value.toLocaleLowerCase())
              )
              .map((user) => (
                <li key={user.id}>{user.name}</li>
              ))}
          </ul>
        </>
      )}
    </section>
  );
}
