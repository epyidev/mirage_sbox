# Sandbox.CodeGeneratorAttribute

An attribute that can be added to a custom `System.Attribute` class for special code generation behavior.
They'll then be applied to methods and properties when they are decorated with <i>that</i> attribute.

- **Kind:** attribute
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.System`
- **Base:** `System.Attribute`

## Constructors

- `CodeGeneratorAttribute(Sandbox.CodeGeneratorFlags type, System.String callbackName, System.Int32 priority)`
  - Perform code generation for a method or property.
  - `type`: The type of code generation you want to do.
You will need to specify whether it should apply to instance or static methods and properties using the `Sandbox.CodeGeneratorFlags.Instance`
and `Sandbox.CodeGeneratorFlags.Static` flags.
  - `callbackName`: The name of the callback method. This can be a fully qualified static method callback or a simple callback to invoke
on the target object if the method or property target is not static.
  - `priority`: Attributes with a higher priority will wrap the target first. The default priority is 0.

## Properties

- `System.Int32 Priority`
  - Attributes with a higher priority will wrap the target first. The default priority is 0.
- `System.String CallbackName`
  - The name of the callback method. This can be a fully qualified static method callback or a simple callback to invoke
on the target object if the method or property target is not static.
- `Sandbox.CodeGeneratorFlags Type`
  - The type of code generation you want to do.
You will need to specify whether it should apply to instance or static methods and properties using the `Sandbox.CodeGeneratorFlags.Instance`
and `Sandbox.CodeGeneratorFlags.Static` flags.
