import './index.css';
import React, {useState} from 'react';
import List from '../List';
import Input from '../Input';

function App() {
  //text state
  const [text, setText] = useState("");
  

  //handle text
  //
  //
  return (
    <div className="App">
      <h1>Hello World</h1>
      <List></List>
      <Input></Input>
    </div>
  );
}

export default App;
