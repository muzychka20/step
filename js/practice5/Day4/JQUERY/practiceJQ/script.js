$(document).ready(function() {
    $('#redButton').click(function() {
        $('.red').addClass('shadow')
        $('.green').removeClass('shadow')
        $('.orange').removeClass('shadow')
        $('.yellow').removeClass('shadow')
    })


    $('#greenButton').click(function() {
        $('.green').addClass('shadow')
        $('.red').removeClass('shadow')
        $('.orange').removeClass('shadow')
        $('.yellow').removeClass('shadow')
    })

    $('#orangeButton').click(function() {
        $('.orange').addClass('shadow')
        $('.green').removeClass('shadow')
        $('.red').removeClass('shadow')
        $('.yellow').removeClass('shadow')
    })

    $('#yellowButton').click(function() {
        $('.yellow').addClass('shadow')
        $('.green').removeClass('shadow')
        $('.orange').removeClass('shadow')
        $('.red').removeClass('shadow')
    })
})
