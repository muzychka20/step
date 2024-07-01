let over_blocks = document.querySelector('.over_blocks')

over_blocks.addEventListener('mouseover', function(event) {
    let block = event.target.closest('.over_block')
    if (!block) return
    block.style.cssText = 'background-color: #fea'
})

over_blocks.addEventListener('mouseout', function(event) {
    let block = event.target.closest('.over_block')
    if (!block) return
    block.style.cssText = ''
})
