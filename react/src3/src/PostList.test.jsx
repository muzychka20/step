import React from 'react';
import { render } from '@testing-library/react';
import '@testing-library/jest-dom';
import PostList from './PostList';

test('renders posts correctly', () => {
  const posts = [
    { id: 1, title: 'Post 1', body: 'This is the first post.' },
    { id: 2, title: 'Post 2', body: 'This is the second post.' }
  ];

  const { getByText } = render(<PostList posts={posts} />);

  expect(getByText('Post 1')).toBeInTheDocument();
  expect(getByText('This is the first post.')).toBeInTheDocument();
  expect(getByText('Post 2')).toBeInTheDocument();
  expect(getByText('This is the second post.')).toBeInTheDocument();
});
