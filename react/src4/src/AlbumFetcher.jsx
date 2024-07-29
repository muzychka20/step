import React, { useState } from 'react';
import { fetchAllAlbums, fetchAlbumById, createAlbum } from './api';

function AlbumFetcher() {
  const [albums, setAlbums] = useState([]);
  const [album, setAlbum] = useState(null);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState(null);
  const [albumId, setAlbumId] = useState('');
  const [newAlbumTitle, setNewAlbumTitle] = useState('');

  const handleFetchAll = async () => {
    setLoading(true);
    setError(null);
    try {
      const data = await fetchAllAlbums();
      setAlbums(data);
    } catch (err) {
      setError(err.message);
    } finally {
      setLoading(false);
    }
  };

  const handleFetchById = async () => {
    setLoading(true);
    setError(null);
    try {
      const data = await fetchAlbumById(albumId);
      setAlbum(data);
    } catch (err) {
      setError(err.message);
    } finally {
      setLoading(false);
    }
  };

  const handleCreateAlbum = async () => {
    setLoading(true);
    setError(null);
    try {
      const data = await createAlbum({ title: newAlbumTitle });
      setAlbums([data, ...albums]);
    } catch (err) {
      setError(err.message);
    } finally {
      setLoading(false);
    }
  };

  return (
    <div>
      <h1>Album Fetcher</h1>
      <button onClick={handleFetchAll}>Fetch All Albums</button>
      <div>
        <input
          type="number"
          value={albumId}
          onChange={(e) => setAlbumId(e.target.value)}
          placeholder="Album ID"
        />
        <button onClick={handleFetchById}>Fetch Album by ID</button>
      </div>
      <div>
        <input
          type="text"
          value={newAlbumTitle}
          onChange={(e) => setNewAlbumTitle(e.target.value)}
          placeholder="New Album Title"
        />
        <button onClick={handleCreateAlbum}>Create Album</button>
      </div>
      {loading && <p>Loading...</p>}
      {error && <p>{error}</p>}
      {album && (
        <div>
          <h3>Album Details</h3>
          <p>ID: {album.id}</p>
          <p>Title: {album.title}</p>
        </div>
      )}
      <ul>
        {albums.map((album) => (
          <li key={album.id}>{album.title}</li>
        ))}
      </ul>
    </div>
  );
}

export default AlbumFetcher;
