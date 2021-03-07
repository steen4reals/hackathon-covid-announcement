import React from "react";
import "./index.css";

function ListItem({ date, description, industry, title }) {
  return (
    <article className="list-item">
      <div className="title">
        {date}
        <h2>{title}</h2>
        <h3>{industry}</h3>
      </div>
      <div className="description">
        {/* if description is falsy resolve to "No results . . ." */}
        <p>{description ?? "No results . . ."}</p>
      </div>
    </article>
  );
}

export default ListItem;
