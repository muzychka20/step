let typeEventsBlocks = document.querySelector('.type_events_blocks')

function showEvent(event) {
    let target = event.target.closest('.type_events_block')
    if (!target) return
    
    let colorBlockStyle = window.getComputedStyle(target)
    let backgroundColor = colorBlockStyle.backgroundColor

    target.innerHTML = "Type: " + event.type + "\nColor" + backgroundColor
}

typeEventsBlocks.addEventListener('click', showEvent)
typeEventsBlocks.addEventListener('mouseover', showEvent)
typeEventsBlocks.addEventListener('dblclick', showEvent)