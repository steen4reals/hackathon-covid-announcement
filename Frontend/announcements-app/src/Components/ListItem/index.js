import React from 'react';
import './index.css';

function ListItem({ date, description, industry, title }) {
  return (
    <div className="list-item">
      <li>
        {date}
        <h2>{title}</h2>
        <h3>{industry}</h3>
        <p></p>
        {description}
      </li>
    </div>
  );
}

export default ListItem;
