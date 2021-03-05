import React from 'react';

function ListItem({ date, description, industry, title }) {
  return (
    <li>
      {date}
      <h2>{title}</h2>
      <h3>{industry}</h3>
      <p></p>
      {description}
    </li>
  );
}

export default ListItem;
