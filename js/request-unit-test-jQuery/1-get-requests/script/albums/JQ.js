export class JQ {    
    #data

    constructor(_url) {
        $.ajax({
            url: _url,                	
            method: 'GET'
        }).done(data => {            
            this.#data = data
        }).fail(error => {
            console.error('jQuery.ajax Error:', error)
        });
    }    

    getResponse() {        
        return this.#data
    }
}