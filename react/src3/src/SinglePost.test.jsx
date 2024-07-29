import React from 'react';
import { render, screen, fireEvent, waitFor } from '@testing-library/react';
import { http } from 'msw';
import { setupServer } from 'msw/node';
import SinglePost from './SinglePost';

const server = setupServer(
  http.get('https://jsonplaceholder.typicode.com/posts/:postId', (req, res, ctx) => {
    return res(
      ctx.json({ id: req.params.postId, title: 'Test Post', body: 'This is a test post.' })
    );
  })
);

beforeAll(() => server.listen({ onUnhandledRequest: 'warn' }));
afterEach(() => server.resetHandlers());
afterAll(() => server.close());

// test('renders post correctly after fetching', async () => {
//   render(<SinglePost />);

//   fireEvent.change(screen.getByLabelText(/Post ID/i), { target: { value: '1' } });
//   fireEvent.click(screen.getByText(/Fetch Post/i));

//   await waitFor(() => {
//     expect(screen.getByText('Test Post')).toBeInTheDocument();
//     expect(screen.getByText('This is a test post.')).toBeInTheDocument();
//   });
// });

test('handles server error', async () => {
  server.use(
    http.get('https://jsonplaceholder.typicode.com/posts/:postId', (req, res, ctx) => {
      return res(ctx.status(500));
    })
  );

  render(<SinglePost />);

  fireEvent.change(screen.getByLabelText(/Post ID/i), { target: { value: '1' } });
  fireEvent.click(screen.getByText(/Fetch Post/i));

  await waitFor(() => {
    expect(screen.getByText(/There was an error fetching the post/i)).toBeInTheDocument();
  });
});
