import './index.css';
import React, { useState } from 'react';
import List from '../List';
import Input from '../Input';

function App() {
  //text state
  const [text, setText] = useState('');
  //handle text
  function handleChange(event) {
    setText(event.target.value);
  }
  //
  return (
<<<<<<< HEAD
    <div className="app" data-testid="app">
      <h1 className="h1">Covid-19 Announcements</h1>
=======
    <div className="app" data-testid = 'app'>
      <h1>Covid-19 Announcements</h1>
>>>>>>> 2dc08debe9670fadb096433089f1d2f37bbe2457
      <Input text={text} handleText={handleChange}></Input>
      <List text={text}></List>
    </div>
  );
}
export default App;
