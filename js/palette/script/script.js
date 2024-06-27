import * as getColorParameters from './getColorParameters.js' 
import * as validateInput from '../script/validateInput.js'
import * as cookie from '../script/cookie.js'
import { addBlock } from './addBlock.js'

let colors = []

document.getElementById('addColorForm').addEventListener('submit', (event) => {
    event.preventDefault()
    
    const colorParameters = getColorParameters.getAll()
    const validName = validateInput.validateOnlyLetters(colorParameters.name)
    const validCode = validateInput.validateColorCode(colorParameters)

    if (validName && validCode) {        
        addBlock(colorParameters)        
        colors.push(colorParameters)        
        let colorString = JSON.stringify(colors)
        cookie.setCookie('colors', colorString, 3)
    }
})


window.onload = () => {
    colors = cookie.getCookie('colors')    
    if (colors) {
        colors = JSON.parse(colors)        
    } else {
        colors = [
            {
                name: 'YELLOWGREEN',
                type: 'RGB',
                code: '154, 205, 50',
            },
            {
                name: 'DARKCYAN',
                type: 'RGBA',
                code: '0, 139, 139, 1',
            },
            {
                name: 'ORANGERED',
                type: 'HEX',
                code: '#FF4500',
            },
        ]
    }
    for (let color of colors) {
        addBlock(color)            
    }
    let colorString = JSON.stringify(colors)
    cookie.setCookie('colors', colorString, 3)
}