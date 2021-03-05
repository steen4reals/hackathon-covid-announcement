## Disney Ideation

### Dreamer

To do list app
Bike Library app
'pokemon' style sprites
netflix/bockbluster library
Covid announcement centre thing
Quiz app 2 player, online gaming ranking system
Excersize app

### Realist

Covid announcement - could be kept simple - just cover uk announcments in coming dates
1 database - id, date, title, descprition
Up until 21st june

# Backend

## Database

Create postgres database with 4 columns (id, date, title, description)
Host on heroku
5 stages/rows
optional --- **query string** --- optional

### Testing Xunit

Use NSubstitute
Use fluent assertions lib
Test GetAll function
1 test for each controller method

## MVC

Controller with usual methods
Repository with usual methods
Follow REST principles CRUD, https etc
Post function for updates --- optional

# FrontEnd

## Component tree

app

    list/use grid
        --- list item

    Input (linked to query search)
        --- dates/buttons

**App**


- Text state

- useReducer

**List**

- Announcement state

- Fetch useEffect

**Strech goal**

- Custome useFetch

**List item**

- Stateless component

**Input**

- Stateless component

- Functions given to update text

## Testing Jest

- Check if app loads

- Check it Li renders

- Test the reducer

## Critic

- If useReducer is too hard, switch to useState, and leave the test for it
- Could be a touchy so stick to main announcemnets, stay neutral
- Run locally
