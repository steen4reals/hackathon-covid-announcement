import { render } from '@testing-library/react';

import Input from './';

const testProps = {
  handleText: jest.fn(),
  text: 'test',
};

test('When passed in props, renders in the DOM', () => {
  //arrange
  const { getByTestId } = render(<Input {...testProps} />);
  const actual = getByTestId('input');
  expect(actual).toBeInTheDocument();
});
