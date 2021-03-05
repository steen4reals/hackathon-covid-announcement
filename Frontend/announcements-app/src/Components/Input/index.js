import React from 'react';
import './index.css';
//pass in handle text
function Input({ handleText, text }) {
  return (
    <div className="input" data-testid="input">
      <input onChange={(event) => handleText(event)} />
      <p>{text}</p>
    </div>
  );
}
export default Input;
