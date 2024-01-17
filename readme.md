# Twilight Tournament

A website where people can register with their discord username and sign up for a tournament.

## Components

### Auth
Provided by Discord.  

### Frontend
Website in Vue with:

1. Discord-based auth.
2. The option to sign up for a tournament.
3. A page where you can see the current status of all the games. Also links to see the different games.
4. A scoreboard.
5. For each game, one player will be assigned to host it with instructions on all the settings for it.

### Backend
Dotnet Server with:

1. Static file hosting for the frontend.
2. HTTP API for frontend.
3. Discord bot for notifications and announcements.
4. WebPushNotification support.
5. Automatic polling of active games to show their status.

### Database
A reliable database to store stuff in. Probably Postgre.

#### User Table
* Internal User ID
* Discord ID
* Twilight Wars ID
* Avatar Link

#### Game Table
* Internal Game ID
* Twilight Wars Game ID
* Game Name
* Tournament ID
* Start: Timestamp
* End: Timestamp

#### Game/User Mapping Table
* Internal User ID
* Internal Game ID

#### Tournament Table
* Tournament ID
* Tournament Name
* Start: Timestamp
* End: Timestamp

#### Status Table
*Potentially just store this as json*

* Internal Game ID
* Fetched At: Timestamp
* Active: Bool
* Last Action: Timestamp
* Victory Point Target: int
* Victory Points

