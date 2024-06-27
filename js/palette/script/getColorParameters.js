const getColorParameters = {
    getAll: () => {        
        return {
            name: getColorName(),
            type: getColorType(),
            code: getColorCode(),
        }
    },
    
    getColorType: () => {
        const selection = document.getElementById('select_type')
        return selection.options[selection.selectedIndex].text
    },

    getColorName: () => {
        return document.getElementById('input_color').value.toUpperCase()
    },

    getColorCode: () => {
        return document.getElementById('input_code').value.toUpperCase()    
    },
}

export const getAll = getColorParameters.getAll
export const getColorType = getColorParameters.getColorType
export const getColorName = getColorParameters.getColorName
export const getColorCode = getColorParameters.getColorCode