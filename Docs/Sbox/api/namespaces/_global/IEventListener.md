# Sandbox.PartyRoom.IEventListener

- **Kind:** interface
- **Namespace:** `(global)`
- **Assembly:** `Sandbox.Engine`
- **Declaring type:** `Sandbox.PartyRoom`

## Methods

### Instance methods

- `virtual System.Void OnJoinedParty(Sandbox.PartyRoom party)`
  - Called when we join a party.
- `virtual System.Void OnLeftParty(Sandbox.PartyRoom party)`
  - Called when we leave a party.
- `virtual System.Void OnChatMessage(Sandbox.Friend sender, System.String message)`
  - A lobby member has sent a chat message.
- `virtual System.Void OnVoiceMessage(Sandbox.Friend sender, System.Byte[] data)`
  - A lobby member has sent a voice packet.
- `virtual System.Void OnMemberJoin(Sandbox.Friend sender)`
  - A lobby member has joined.
- `virtual System.Void OnMemberLeave(Sandbox.Friend sender)`
  - A lobby member has left.
