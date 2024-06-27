$(document).ready(function() {
    $('li').mouseover(function() {        
        let current = $(this)        
        $('li').each(function(index) {
            $(this).addClass('hovered-stars')
            if (index == current.index()){
                return false
            }
        })
    })

    $('li').mouseleave(function() {
        $('li').removeClass('hovered-stars')
    })

    $('li').click(function() {
        $('li').removeClass('clicked-stars')
        $('.hovered-stars').addClass('clicked-stars')
    })
})
