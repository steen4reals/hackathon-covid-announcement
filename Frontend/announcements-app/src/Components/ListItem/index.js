import React from 'react';
import './index.css';

function ListItem({ date, description, industry, title }) {
  return (
    <article className="list-item">
      <div className="title">
        {date.slice(0, 10)}
        <h2>{title}</h2>
        <h3>{industry}</h3>
      </div>
      <div className="description">
        <p>{description}</p>
      </div>
    </article>
  );
}

export default ListItem;
