import ListItem from '../ListItem';
import useFetch from '../../Hooks/useFetch';

const API_URL = 'http://localhost:5000/announcement';

function List({ text }) {
  const announcements = useFetch(`${API_URL}?search=${text}`, text);

  if (!announcements || announcements.length === 0) {
    return (
      <ListItem
        title={''}
        description={'No results . . .'}
        industry={''}
        date={''}
      />
    );
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
