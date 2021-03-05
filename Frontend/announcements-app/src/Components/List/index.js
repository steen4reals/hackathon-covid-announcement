import React, { useState, useEffect } from 'react';
import ListItem from '../ListItem';

const url = 'http://localhost:5000/announcement';

const announcementsArr = [
  {
    date: '2021-03-08T00:00:00',
    description: 'Schools return, with Covid-19 testing in place.',
    id: 1,
    industry: 'Education',
    title: 'Stage 1a',
  },
];

function List({ text }) {
  //announcements state
  const [announcements, setAnnouncements] = useState(announcementsArr);
  //useEffect for fetching api
  useEffect(() => {
    async function getData() {
      let res = await fetch(`${url}?search=${text}`);
      let data = await res.json();
      setAnnouncements(data);
    }
    getData();
  }, [text]);

  console.log(announcements);

  return (
    <div className="list">
      {/* map array of announcements fecthed into ListItems             */}
      <ul>
        {announcements.map((a) => (
          <ListItem
            title={a.title}
            key={a.id}
            description={a.description}
            industry={a.industry}
            date={a.date}
          />
        ))}
      </ul>
    </div>
  );
}

export default List;
