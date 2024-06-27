$(document).ready(() => {    
    function handleButtonClick(color) {
        $('.shadow').removeClass('shadow')
        $('.' + color).addClass('shadow')
    }

    $('#redButton').click(() => {
        handleButtonClick('red')
    })

    $('#greenButton').click(() => {
        handleButtonClick('green')
    })

    $('#orangeButton').click(() => {
        handleButtonClick('orange')
    })

    $('#yellowButton').click(() => {
        handleButtonClick('yellow')
    })
})
