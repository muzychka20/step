let colorsBlock = document.querySelector('.colors_blocks')
let resBlock = document.getElementById('result_block')

function changeColor(block, color) {
    block.style.backgroundColor = color
}

colorsBlock.addEventListener("click", function(event) {
    let colorBlock = event.target.closest('.color_block')
    if (!colorBlock) return
    
    let colorBlockStyle = window.getComputedStyle(colorBlock)
    let backgroundColor = colorBlockStyle.backgroundColor

    changeColor(resBlock, backgroundColor)    
})