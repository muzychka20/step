import * as checkPattern from '../script/checkPattern.js'
import * as cookie from '../script/cookie.js'

const validateValue = {
    validateOnlyLetters: (str) => {
        const onlyLetters = checkPattern.checkOnlyLetters(str)
        
        if (!onlyLetters) {
            document.getElementById('wrong_data_name').innerText = 'Color can only contain letters'
            return false
        }
        
        const colorString = cookie.getCookie('colors')
        if (colorString) {
            const colors = JSON.parse(colorString)
            const colorExists = colors.some(color => color.name === str)
            if (colorExists) {
                document.getElementById('wrong_data_name').innerText = 'This color already exists'
                return false
            }            
        }

        document.getElementById('wrong_data_name').innerText = ''
        return true
    },

    validateColorCode: (colorParameters) => {
        let errorMessage = ''
        switch (colorParameters.type) {
            case 'HEX':
                errorMessage = checkPattern.checkHexadecimalColors(colorParameters.code) ? '' : 'HEX code must match the pattern\n #[0-9a-fA-F]'
                break
            case 'RGB':
                errorMessage = checkPattern.checkRGBColors(colorParameters.code) ? '' : 'RGB code must match the pattern\n [0-255], [0-255], [0-255]'
                break
            case 'RGBA':
                errorMessage = checkPattern.checkRGBAColors(colorParameters.code) ? '' : 'RGBA code must match the pattern\n [0-255], [0-255], [0-255], [0.0-1.0]'
                break
        }    
        document.getElementById('wrong_data_code').innerText = errorMessage
        return errorMessage == '' ? true : false
    }
}
export const validateOnlyLetters = validateValue.validateOnlyLetters
export const validateColorCode = validateValue.validateColorCode