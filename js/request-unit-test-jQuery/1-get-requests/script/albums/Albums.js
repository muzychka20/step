export class Albums {
    #albums

    constructor(_albums) {
        this.#albums = _albums
    }

    createAlbum(album) {
        let albumBlock = document.createElement('div')
        albumBlock.setAttribute('class', 'album')
    
        let idAlbumContent = document.createElement('p')
        let idContent = document.createElement('p')
        let titleAlbumContent = document.createElement('p')        
    
        let hr = document.createElement('hr')
    
        idAlbumContent.innerHTML = 'User Id: ' + album['userId']
        idContent.innerHTML = 'Id: ' + album['id']
        titleAlbumContent.innerHTML = 'Title: ' + album['title']        
        
        albumBlock.appendChild(idAlbumContent)
        albumBlock.appendChild(idContent)
        albumBlock.appendChild(titleAlbumContent)        
        
        document.getElementById('data').appendChild(albumBlock)
        document.getElementById('data').appendChild(hr)
    }

    displayAlbums() {
        document.getElementById('data').innerHTML = ''        
        this.#albums.forEach(album => {
            this.createAlbum(album)       
        })
    }
}