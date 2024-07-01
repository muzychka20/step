let changeOnBlueBlock = document.querySelector('.change_on_blue_blocks')

changeOnBlueBlock.addEventListener('click', function(event) {
    let target = event.target.closest('.change_on_blue_block')
    if (!target) return
    target.style.backgroundColor = 'blue'
})