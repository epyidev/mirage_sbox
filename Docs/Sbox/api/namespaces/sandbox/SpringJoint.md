# Sandbox.SpringJoint

Try to keep an object a set distance away from another object. Like a spring connecting two objects.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Joint`

## Constructors

- `SpringJoint()`

## Properties

- `System.Single Frequency`
  - The stiffness of the spring
- `System.Single Damping`
  - The damping ratio of the spring, usually between 0 and 1
- `System.Single MinLength`
  - Minimum length it should be allowed to go
- `System.Single MaxLength`
  - Maximum length it should be allowed to go
- `System.Single RestLength`
  - Length of the spring at rest.
- `Sandbox.SpringJoint.SpringForceMode ForceMode`
  - Determines which way the spring applies force.
Pull = only when stretched,
Push = only when compressed,
Both = acts in both directions.
