import { useState } from "react"

export default function CalculatorDivision() {
    const [num1, setNum1] = useState('')
    const [num2, setNum2] = useState('')
    const [result, setResult] = useState('')
    
    const handleCalculate = () => {
        const res = parseFloat(num1) / parseFloat(num2)
        setResult(res.toString())
    }

    return (
        <div>
            <h2>Division</h2>
            <input 
                type="number"
                placeholder="Num1"
                value={num1}
                onChange={(e) => setNum1(e.target.value)}
            />
            <input 
                type="number"
                placeholder="Num2"
                value={num2}
                onChange={(e) => setNum2(e.target.value)}
            />
            <button onClick={handleCalculate}>Calculate</button>
            <p>Result {result}</p>
        </div>
    )
}