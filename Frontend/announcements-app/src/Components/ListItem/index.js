import React from 'react';

function ListItem({date, description, industry, title}) {
    return (
        <ol>
            <li>{date}</li>
            <li>{title}</li>
            <li>{industry}</li>
            <li>{description}</li>
        </ol>
    );
}

export default ListItem;