const checkPattern = {
    checkHexadecimalColors: (str) => {
        const hexColor = /^#([a-f0-9]{6}|[a-f0-9]{3})$/i
        const match = str.match(hexColor)
        return match !== null
    },
    
    checkRGBColors: (str) => {
        const rgbColor = /^(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9]),\s*(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9]),\s*(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9])$/
        const match = str.match(rgbColor)
        return match !== null
    },
    
    checkRGBAColors: (str) => {
        const rgbaColor = /^(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9]),\s*(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9]),\s*(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9]),\s*(0|0?\.\d+|1(\.0+)?)$/
        const match = str.match(rgbaColor)    
        return match !== null
    },

    checkOnlyLetters: (str) => {
        const onlyLetters = (/^[A-Za-z]+$/)
        const match = str.match(onlyLetters)
        return match !== null
    },
}

export const checkHexadecimalColors = checkPattern.checkHexadecimalColors
export const checkRGBColors = checkPattern.checkRGBColors
export const checkRGBAColors = checkPattern.checkRGBAColors
export const checkOnlyLetters = checkPattern.checkOnlyLetters