import { useState, useEffect } from 'react';

function useFetch(URL, dependency) {
  //data state
  const [data, setData] = useState();
  //useEffect for fetching api
  useEffect(() => {
    //GET request: fetch -> parse -> data
    fetch(URL)
      .then((res) => res.json())
      .then((data) => setData(data));
  }, [dependency, URL]);

  return data;
}

export default useFetch;
