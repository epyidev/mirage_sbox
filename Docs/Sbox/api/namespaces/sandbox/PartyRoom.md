# Sandbox.PartyRoom

A Party. A Party with your friends.

- **Kind:** class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`

## Properties

- `static Sandbox.PartyRoom Current`
- `Sandbox.SteamId Id`
  - The unique identifier of this lobby
- `System.String Name`
  - The name of this lobby.
- `System.Int32 MaxMembers`
  - The maximum number of members allowed in this lobby.
- `System.Int32 MemberCount`
  - The current number of members in this lobby.
- `System.Boolean VoiceCommunicationAllowed`
  - Allow communication via voice when in the main menu.
- `System.Boolean VoiceRecording`
- `System.Collections.Generic.IEnumerable<Sandbox.Friend> Members`
  - A list of members in this room
- `Sandbox.Friend Owner`
- `System.String PackageIdent`
  - What package is this party's owner playing?
- `System.Action<Sandbox.Friend,System.String> OnChatMessage`
- `System.Action<Sandbox.Friend> OnJoin`
- `System.Action<Sandbox.Friend> OnLeave`
- `System.Action<Sandbox.Friend,System.Byte[]> OnVoiceData`
- `Sandbox.PartyRoom.OwnerJoinState JoinState`
  - The current join state of the owner of the party

## Methods

### Static methods

- `static System.Threading.Tasks.Task<Sandbox.PartyRoom> Create(System.Int32 maxMembers)`
- `static System.Threading.Tasks.Task<Sandbox.PartyRoom> Create(System.Int32 maxMembers, System.String name, System.Boolean ispublic)`
- `static System.Threading.Tasks.Task<Sandbox.PartyRoom.Entry[]> Find()`

### Instance methods

- `System.Void Leave()`
- `System.Boolean SetOwner(Sandbox.SteamId friend)`
  - Set the owner to someone else. You need to be the owner
- `System.Void SendChatMessage(System.String text)`
- `System.Void Kick(Sandbox.SteamId friend)`
  - Kick a member from the lobby. Only the owner can kick members.
