import React, { useState } from 'react';

const SimpleCalculator = () => {
  const [num1, setNum1] = useState('');
  const [num2, setNum2] = useState('');
  const [result, setResult] = useState('');

  const handleCalculate = () => {
    const res = parseFloat(num1) + parseFloat(num2);
    setResult(res.toString());
  };

  return (
    <div>
      <h2>Простий калькулятор</h2>
      <input
        type="number"
        placeholder="Введіть перше число"
        value={num1}
        onChange={(e) => setNum1(e.target.value)}
      />
      <input
        type="number"
        placeholder="Введіть друге число"
        value={num2}
        onChange={(e) => setNum2(e.target.value)}
      />
      <button onClick={handleCalculate}>Обчислити</button>
      <p>Результат: {result}</p>
    </div>
  );
};

export default SimpleCalculator;