import { useEffect, useState } from "react";
import styled from "styled-components";

const HeaderContainer = styled.header`
  height: 50px;
  display: flex;
  padding: 0 2rem;
  justify-content: space-between;
  align-items: center;
  border-bottom: 1px solid #ccc;
  background: #fafafa;
`;

export default function Header() {
  const [time, setTime] = useState(new Date());

  useEffect(() => {
    const interval = setInterval(() => {
      setTime(new Date());
    }, 1000);

    return () => {
      clearInterval(interval);
      console.log("cleaning");
    };
  }, []);

  return (
    <HeaderContainer>
      <img src={"logo-name.svg"} alt={"Result"} />
      <span>Time: {time.toLocaleTimeString()}</span>
    </HeaderContainer>
  );
}
