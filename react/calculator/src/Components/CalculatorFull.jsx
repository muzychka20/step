import CalculatorPlus from "./CalculatorOperations/CalculatorPlus/CalculatorPlus"
import CalculatorDivision from "./CalculatorOperations/CalculatorDivision/CalculatorDivision"
import CalculatorMultiply from "./CalculatorOperations/CalculatorMultiply/CalculatorMultiply"
import CalculatorSubstract from "./CalculatorOperations/CalculatorSubtract/CalculatorSubstract"
import Button from "./Button"

export default function CalculatorFull() {   
    return (
       <div>
        <CalculatorPlus/>
        <CalculatorSubstract/>
        <CalculatorMultiply/>
        <CalculatorDivision/>
        <Button/>
       </div>
    )
}