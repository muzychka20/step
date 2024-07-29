// import { fetchAllAlbums, fetchAlbumById, createAlbum } from './api';
// import { setupServer } from 'msw/node';
// import { rest } from 'msw';
// import { describe, it, expect, beforeAll, afterEach, afterAll } from 'vitest';

// // Мокування серверу
// const server = setupServer(
//   rest.get('https://jsonplaceholder.typicode.com/albums', (req, res, ctx) => {
//     return res(
//       ctx.json([
//         { id: 1, title: 'Album 1' },
//         { id: 2, title: 'Album 2' },
//       ])
//     );
//   }),
//   rest.get('https://jsonplaceholder.typicode.com/albums/:id', (req, res, ctx) => {
//     const { id } = req.params;
//     return res(
//       ctx.json({ id: Number(id), title: `Album ${id}` })
//     );
//   }),
//   rest.post('https://jsonplaceholder.typicode.com/albums', (req, res, ctx) => {
//     const { title } = req.body;
//     return res(
//       ctx.json({ id: Math.random(), title })
//     );
//   })
// );

// // Запуск сервера перед усіма тестами та його закриття після них
// beforeAll(() => server.listen({ onUnhandledRequest: 'warn' }));
// afterEach(() => server.resetHandlers());
// afterAll(() => server.close());

// describe('API tests', () => {
//   it('fetches all albums', async () => {
//     const albums = await fetchAllAlbums();
//     expect(albums).toHaveLength(2);
//     expect(albums[0].title).toBe('Album 1');
//     expect(albums[1].title).toBe('Album 2');
//   });

//   it('fetches album by ID', async () => {
//     const album = await fetchAlbumById(1);
//     expect(album).toEqual({ id: 1, title: 'Album 1' });
//   });

//   it('creates a new album', async () => {
//     const newAlbum = { title: 'New Album' };
//     const createdAlbum = await createAlbum(newAlbum);
//     expect(createdAlbum.title).toBe('New Album');
//   });

//   it('handles fetch error', async () => {
//     server.use(
//       rest.get('https://jsonplaceholder.typicode.com/albums/:id', (req, res, ctx) => {
//         return res(ctx.status(404));
//       })
//     );

//     await expect(fetchAlbumById(999)).rejects.toThrow('Error fetching album with ID 999');
//   });

//   it('handles create error', async () => {
//     server.use(
//       rest.post('https://jsonplaceholder.typicode.com/albums', (req, res, ctx) => {
//         return res(ctx.status(500));
//       })
//     );

//     const newAlbum = { title: 'New Album' };
//     await expect(createAlbum(newAlbum)).rejects.toThrow('Error creating new album');
//   });
// });
