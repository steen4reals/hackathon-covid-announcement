import React, { useState, useEffect } from 'react';
import ListItem from '../ListItem';

import useFetch from '../../Hooks/useFetch';

const API_URL = 'http://localhost:5000/announcement';

function List({ text }) {
  const announcements = useFetch(`${API_URL}?search=${text}`, text);

  if (!announcements) {
    return <p>Loading...</p>;
  }

  return (
    <section className="list">
      {/* map array of announcements fecthed into ListItems*/}
      {announcements.map((a) => (
        <ListItem
          key={a.id}
          title={a.title}
          description={a.description}
          industry={a.industry}
          date={a.date}
        />
      ))}
    </section>
  );
}

export default List;
