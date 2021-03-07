import './index.css';
import React, { useState } from 'react';
import List from '../List';
import Input from '../Input';

function App() {
  //text state
  const [text, setText] = useState('');
  //handle text
  function handleText(e) {
    setText(e.target.value);
  }

  return (
    <div className="app" data-testid="app">
      <h1>Covid-19 Announcements</h1>
      <Input text={text} handleText={handleText}></Input>
      <List text={text}></List>
    </div>
  );
}
export default App;
