CREATE TABLE Announcements (
    Id SERIAL PRIMARY KEY,
    Date Date,
    Title VARCHAR (20),
    Industry VARCHAR(20),
    Description TEXT
);

INSERT INTO 
    Announcements (Date, Title, Industry, Description)
VALUES
    ('2021-03-08', 'Stage 1a', 'Education', 'Schools return, with Covid-19 testing in place.'),
    ('2021-03-08', 'Stage 1a', 'Education', 'Colleges and Universities to reopen.'),
    ('2021-03-08', 'Stage 1a', 'Social', 'Can meet outdoors with 1 other person from 1 other household.'),
    ('2021-03-29', 'Stage 1b', 'Social', 'Can meet outdoors with a 2 household limit.'),
    ('2021-03-29', 'Stage 1b', 'Social', 'Can meet outdoors with a maximum of 6 people.'),
    ('2021-04-12', 'Stage 2', 'Hospitality', 'Pubs and resturants to reopen, with outdoor service only.'),
    ('2021-04-12', 'Stage 2', 'Health', 'Gyms to reopen.'),
    ('2021-04-12', 'Stage 2', 'Retail', 'Non-essential shops to reopen.'),
    ('2021-04-12', 'Stage 2', 'Services', 'Hairdressers, salons and spas to reopen.'),
    ('2021-04-12', 'Stage 2', 'Family', 'Indoor child activities reopen with 15 adult limit.'),
    ('2021-04-12', 'Stage 2', 'Travel', 'Domestic holidays permitted.'),
    ('2021-04-12', 'Stage 2', 'Ceremonies', 'Wedding events with a limit of 15 people.'),
    ('2021-05-17', 'Stage 3', 'Hospitality', 'Pubs and resturants to reopen, with indoor service.'),
    ('2021-05-17', 'Stage 3', 'Ceremonies', 'Weddings and christening events with a limit of 30 people allowed.'),
    ('2021-05-17', 'Stage 3', 'Entertainment', 'Performances and large events reopen, at half capacity.'),
    ('2021-05-17', 'Stage 3', 'Family', 'Children play areas to reopen.'),
    ('2021-05-17', 'Stage 3', 'Travel', 'Hotels, hostels, B&Bs to reopen for non-emergency use.'),
    ('2021-05-17', 'Stage 3', 'Travel', 'International leisure travel to resume.'),
    ('2021-06-21', 'Stage 4', 'Social', 'Can meet outdoors with no limit.'),
    ('2021-06-21', 'Stage 4', 'Entertainment', 'Nightclubs to reopen.'),
    ('2021-06-21', 'Stage 4', 'Ceremonies', 'Weddings and christenings with no limit.');
    