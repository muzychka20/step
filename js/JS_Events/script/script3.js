let blockSize = document.getElementById('block_size')

blockSize.addEventListener('click', function() {
    blockSize.style.width = blockSize.offsetWidth * 2 + 'px'
    blockSize.style.height = blockSize.offsetHeight * 2 + 'px'
})

blockSize.addEventListener('contextmenu', function() {
    blockSize.style.width = blockSize.offsetWidth / 2 + 'px'
    blockSize.style.height = blockSize.offsetHeight / 2 + 'px'
})