# Sandbox.Streamer

- **Kind:** static class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static System.String Username`
  - Your own username
- `static System.String UserId`
  - Your own user id
- `static Sandbox.StreamService Service`
  - The service type (ie "Twitch")
- `static System.Boolean IsActive`
  - Are we connected to a service
- `static System.String Game`
  - Set the game you're playing by game id
- `static System.String Language`
  - Set the language of your stream
- `static System.String Title`
  - Set the title of your stream
- `static System.Int32 Delay`
  - Set the delay of your stream
- `static System.Int32 ViewerCount`
  - Amount of concurrent viewer your stream has.

## Methods

### Static methods

- `static System.Threading.Tasks.Task<Sandbox.StreamUser> GetUser(System.String username)`
  - Get user information. If no username is specified, the user returned is ourself
- `static System.Void SendMessage(System.String message)`
  - Send a message to chat, optionally specify channel you want to send the message, otherwise it is sent to your own chat
- `static System.Void ClearChat()`
  - Clear your own chat
- `static System.Void BanUser(System.String username, System.String reason, System.Int32 duration)`
  - Ban user from your chat by username, the user will no longer be able to chat.
Optionally specify the duration, a duration of zero means perm ban
(Note: You have to be in your chat for this to work)
- `static System.Void UnbanUser(System.String username)`
  - Unban user from your chat by username
(Note: You have to be in your chat for this to work)
