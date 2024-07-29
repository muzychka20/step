import { useState, useEffect } from 'react'
import axios from 'axios'

export default function Post(props) {    
    return (
        <>
            <li key={props.post.id}>
                <h2>{props.post.title}</h2>
                <p>{props.post.body}</p>
            </li>        
        </>
    )
    
}