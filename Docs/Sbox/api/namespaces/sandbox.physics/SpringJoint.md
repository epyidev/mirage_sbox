# Sandbox.Physics.SpringJoint

A rope-like constraint that is has springy/bouncy.

- **Kind:** class
- **Namespace:** `Sandbox.Physics`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Physics.PhysicsJoint`

## Properties

- `Sandbox.Physics.PhysicsSpring SpringLinear`
  - How springy and tight the joint will be
- `System.Single MaxLength`
  - Maximum length it should be allowed to go
- `System.Single MinLength`
  - Minimum length it should be allowed to go. At which point it acts a bit like a rod.
- `System.Single MaxForce`
  - Maximum force it should be allowed to go. Set to zero to only allow stretching.
- `System.Single MinForce`
  - Minimum force it should be allowed to go.
- `System.Single ReferenceMass`
