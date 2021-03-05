import React, { useState, useEffect } from 'react';

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

function List() {
  //announcements state
  const [announcements, setAnnouncements] = useState(announcementsArr);
  //useEffect for fetching api
  useEffect(() => {
    async function getData() {
      let res = await fetch(url);
      let data = await res.json();
      setAnnouncements(data);
    }
    getData();
  }, []);

  console.log(announcements);

  return (
    <div>
      {/* map array of announcements fecthed into ListItems             */}
    </div>
  );
}

export default List;
