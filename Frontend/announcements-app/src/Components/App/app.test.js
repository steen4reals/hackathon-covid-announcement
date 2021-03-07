import { render } from '@testing-library/react';

import App from './';

test('Renders in the DOM', () => {
  //arrange
  const { getByTestId } = render(<App />);
  const actual = getByTestId('app');
  expect(actual).toBeInTheDocument();
});
