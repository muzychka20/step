export class Comments {
    #comments

    constructor(_comments) {
        this.#comments = _comments
    }

    createComment(comment) {
        let commentBlock = document.createElement('div')
        commentBlock.setAttribute('class', 'comment')
    
        let idPostContent = document.createElement('p')
        let idContent = document.createElement('p')
        let titleContent = document.createElement('p')
        let emailContent = document.createElement('p')
        let bodyContent = document.createElement('p')
    
        let hr = document.createElement('hr')
    
        idPostContent.innerHTML = 'Post Id: ' + comment['postId']
        idContent.innerHTML = 'Id: ' + comment['id']
        titleContent.innerHTML = 'Name: ' + comment['name']
        emailContent.innerHTML = 'Email: ' + comment['email']
        bodyContent.innerHTML = 'Body: ' + comment['body']
        
        commentBlock.appendChild(idPostContent)
        commentBlock.appendChild(idContent)
        commentBlock.appendChild(titleContent)
        commentBlock.appendChild(emailContent)
        commentBlock.appendChild(bodyContent)
        
        document.getElementById('data').appendChild(commentBlock)
        document.getElementById('data').appendChild(hr)
    }

    displayComments() {
        document.getElementById('data').innerHTML = ''        
        this.#comments.forEach(comment => {
            this.createComment(comment)       
        })
    }
}