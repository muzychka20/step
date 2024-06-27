export class Posts {
    #posts

    constructor(_posts) {
        this.#posts = _posts
    }

    createPost(post) {
        let postBlock = document.createElement('div')
        postBlock.setAttribute('class', 'post')
    
        let idUserContent = document.createElement('p')
        let idContent = document.createElement('p')
        let titleContent = document.createElement('p')
        let bodyContent = document.createElement('p')
    
        let hr = document.createElement('hr')
    
        idUserContent.innerHTML = 'User Id: ' + post['userId']
        idContent.innerHTML = 'Id: ' + post['id']
        titleContent.innerHTML = 'Title: ' + post['title']
        bodyContent.innerHTML = 'Body: ' + post['body']
        
        postBlock.appendChild(idUserContent)
        postBlock.appendChild(idContent)
        postBlock.appendChild(titleContent)
        postBlock.appendChild(bodyContent)
            
        document.getElementById('data').appendChild(postBlock)
        document.getElementById('data').appendChild(hr)
    }

    displayPosts() { 
        document.getElementById('data').innerHTML = ''       
        this.#posts.forEach(post => {
            this.createPost(post)       
        })
    }
}