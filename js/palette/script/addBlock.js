export function addBlock(colorParameters) {        
    let backgroundColor = ''

    switch (colorParameters.type) {
        case 'HEX':
            backgroundColor = `${colorParameters.code}`
            break
        case 'RGB':
            backgroundColor = `rgb(${colorParameters.code})`
            break
        case 'RGBA':
            backgroundColor = `rgba(${colorParameters.code})`
            break
    }

    let colorBlock = document.createElement('div')
    colorBlock.style.backgroundColor = backgroundColor
    colorBlock.classList.add('colorBlock')

    let colorBlockInfoBg = document.createElement('div')
    colorBlockInfoBg.classList.add('colorInfoBg')

    let colorBlockInfo = document.createElement('div')
    colorBlockInfo.classList.add('colorInfo')
    colorBlockInfo.appendChild(appendInfo('colorInfoName', colorParameters.name))
    colorBlockInfo.appendChild(appendInfo('colorInfoType', colorParameters.type))
    colorBlockInfo.appendChild(appendInfo('colorInfoCode', colorParameters.code))
    
    colorBlockInfoBg.appendChild(colorBlockInfo)
    colorBlock.appendChild(colorBlockInfoBg)

    document.getElementById('palette_blocks').appendChild(colorBlock)
}

function appendInfo(className, text) {
    const p = document.createElement('p')
    p.innerText = text
    p.classList.add(className)
    return p
}