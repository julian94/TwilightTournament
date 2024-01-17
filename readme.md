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

