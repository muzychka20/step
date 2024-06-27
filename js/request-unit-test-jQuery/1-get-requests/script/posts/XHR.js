export class XHR {
    #xhr
    #response

    constructor(url) {
        this.#xhr = new XMLHttpRequest()
        this.#xhr.open('GET', url, false)
        this.#xhr.onreadystatechange = () => {
            if (this.#xhr.readyState === 4) {
                this.#response = JSON.parse(this.#xhr.responseText)
            }
        }
        this.#xhr.send()
    }

    getResponse() {
        return this.#response
    }
}