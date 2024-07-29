import axios from 'axios';

const BASE_URL = 'https://jsonplaceholder.typicode.com/albums';

export const fetchAllAlbums = async () => {
  try {
    const response = await axios.get(BASE_URL);
    return response.data;
  } catch (error) {
    throw new Error('Error fetching all albums');
  }
};

export const fetchAlbumById = async (id) => {
  try {
    const response = await axios.get(`${BASE_URL}/${id}`);
    return response.data;
  } catch (error) {
    throw new Error(`Error fetching album with ID ${id}`);
  }
};

export const createAlbum = async (album) => {
  try {
    const response = await axios.post(BASE_URL, album);
    return response.data;
  } catch (error) {
    throw new Error('Error creating new album');
  }
};
