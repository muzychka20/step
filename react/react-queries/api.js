import axios from "axios";

const BASE_URL = "https://jsonplaceholder.typicode.com";

export const fetchAllPosts = async () => {
  try {
    const response = await axios.get(BASE_URL + "/posts");
    return response.data;
  } catch (error) {
    throw new Error("Error fetching all posts");
  }
};

export const fetchAllComments = async () => {
  try {
    const response = await axios.get(BASE_URL + "/comments");
    return response.data;
  } catch (error) {
    throw new Error("Error fetching all comments");
  }
};

export const addComment = async (newComment) => {
  try {
    const response = await axios.post(BASE_URL + "/comments", newComment);
    return response.data;
  } catch (error) {
    throw new Error("Error adding comment");
  }
};

export const addPost = async (newPost) => {
  try {
    const response = await axios.post(BASE_URL + "/posts", newPost);
    return response.data;
  } catch (error) {
    throw new Error("Error adding post");
  }
};

// export const fetchAlbumById = async (id) => {
//   try {
//     const response = await axios.get(`${BASE_URL}/${id}`);
//     return response.data;
//   } catch (error) {
//     throw new Error(`Error fetching album with ID ${id}`);
//   }
// };

// export const createAlbum = async (album) => {
//   try {
//     const response = await axios.post(BASE_URL, album);
//     return response.data;
//   } catch (error) {
//     throw new Error('Error creating new album');
//   }
// };
