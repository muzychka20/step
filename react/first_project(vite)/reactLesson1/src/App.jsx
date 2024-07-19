import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import Header from './Components/Header/Header'
import Main from './Components/Main/Main'
import Footer from './Components/Footer/Footer'
import CalculatorPlus from './Components/CalculatorPlus/CalculatorPlus'
import CalculatorSubstract from './Components/CalculatorSubtract/CalculatorSubstract'
import CalculatorMultiply from './Components/CalculatorMultiply/CalculatorMultiply'
import CalculatorDivision from './Components/CalculatorDivision/CalculatorDivision'

function App() {
  const [count, setCount] = useState(0)

  return (
    <div>
      <Header/>
      <Main/>
      <Footer/>
      <CalculatorPlus/>
      <CalculatorSubstract/>
      <CalculatorMultiply/>
      <CalculatorDivision/>      
    </div>
  )
}

export default App
