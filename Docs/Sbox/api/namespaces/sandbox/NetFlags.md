# Sandbox.NetFlags

- **Kind:** enum
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `System.Enum`

## Values

- `Unreliable` - Message will be sent unreliably. It may not arrive and it may be received out of order. But chances
are that it will arrive on time and everything will be fine. This is good for sending position updates,
or spawning effects. This is the fastest way to send a message. It is also the cheapest.
- `Reliable` - Message will be sent reliably. Multiple attempts will be made until the recipient has received it. Use this for things
like chat messages, or important events. This is the slowest way to send a message. It is also the most expensive.
- `SendImmediate` - Message will not be grouped up with other messages, and will be sent immediately. This is most useful for things like 
streaming voice data, where packets need to stream in real-time, rather than arriving with a bunch of other packets.
- `DiscardOnDelay` - Message will be dropped if it can't be sent quickly. Only applicable to unreliable messages.
- `HostOnly` - Only the host may call this action
- `OwnerOnly` - Only the owner may call this action
- `UnreliableNoDelay` - Message will be sent unreliably, not grouped up with other messages and will be dropped if it can't be sent quickly.
