import React from 'react';
import './index.css';
//pass in handle text
function Input({ handleText, text }) {
  return (
    <div className="input" data-testid="input">
      <input onChange={handleText} value={text} placeholder={'Search'} />
    </div>
  );
}
export default Input;
