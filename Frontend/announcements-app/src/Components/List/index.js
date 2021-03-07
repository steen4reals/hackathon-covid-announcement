import ListItem from "../ListItem";
import Loader from "../Loader";
import useFetch from "../../Hooks/useFetch";

const API_URL = "http://localhost:5000/announcement";

function List({ text }) {
  const announcements = useFetch(`${API_URL}?search=${text}`, text);

  if (!announcements) {
    return <Loader />;
  }

  if (!announcements.length) {
    return <ListItem />;
  }

  return (
    <section className="list">
      {/*map array of announcements fetched into ListItems*/}
      {announcements.map((a) => (
        <ListItem
          key={a.id}
          title={a.title}
          description={a.description}
          industry={a.industry}
          date={a.date.slice(0, 10)}
        />
      ))}
    </section>
  );
}

export default List;
