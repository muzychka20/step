function placeBlock(x, y, element) {            
    element.style.left = x + 'px'
    element.style.top = y + 'px'
}

function handleKeyPress(event) {
    let block = document.getElementById('block')
    let left = block.offsetLeft
    let top = block.offsetTop        
    let code = event.keyCode
    let step = 5

    if (code === 40) {
        placeBlock(left, top + step, block)
    }
    else if (code === 38) {
        placeBlock(left, top - step, block)
    }
    else if (code === 37) {
        placeBlock(left - step, top, block)
    }
    else if (code === 39) {
        placeBlock(left + step, top, block)
    }

    console.log("left: " + left + " top: " + top)
}

window.addEventListener('keydown', handleKeyPress)