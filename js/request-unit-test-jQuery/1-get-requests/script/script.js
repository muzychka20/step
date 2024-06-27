import { XHR } from './posts/XHR.js'
import { Posts } from './posts/Posts.js'
import { Comments } from './comments/Comments.js'
import { Fetch } from './comments/Fetch.js'
import { JQ } from './albums/JQ.js'
import { Albums } from './albums/Albums.js'

document.getElementById('getPostsButton').addEventListener('click', () => {
    let xhr = new XHR('https://jsonplaceholder.typicode.com/posts')
    let posts = new Posts(xhr.getResponse())
    posts.displayPosts()
})



document.getElementById('getCommentsButton').addEventListener('click', () => {
    let fetch = new Fetch('https://jsonplaceholder.typicode.com/comments')    
    setTimeout(() => {
        let comments = new Comments(fetch.getResponse())
        comments.displayComments()        
    }, 500)    
})

document.getElementById('getAlbumsButton').addEventListener('click', () => {
    let jq = new JQ('https://jsonplaceholder.typicode.com/albums')
    setTimeout(() => {
        let albums = new Albums(jq.getResponse())
        albums.displayAlbums()
    }, 500)
})
