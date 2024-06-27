export class Fetch {    
    #data

    constructor(url) {
        this.getData(url)        
    }

    async getData(url) {
        const response = await fetch(url)
        this.#data = await response.json()                
    }

    getResponse() {        
        return this.#data
    }
}