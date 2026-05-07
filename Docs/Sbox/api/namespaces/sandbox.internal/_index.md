# Namespace `Sandbox.Internal`

25 types.

## Classes

- [`PublicArrayPool<T>`](./PublicArrayPool-T.md) - Calls to ArrayPool.Shared{T} will map to this class.
- [`SafeStringBuilder`](./SafeStringBuilder.md) - Calls to `new StringBuilder()` in addon code will map to this class.
- [`TypeLibrary`](./TypeLibrary.md)

## Static classes

- [`GlobalGameNamespace`](./GlobalGameNamespace.md)
- [`GlobalSystemNamespace`](./GlobalSystemNamespace.md)
- [`GlobalToolsNamespace`](./GlobalToolsNamespace.md)

## Attributes

- [`ClassFileLocationAttribute`](./ClassFileLocationAttribute.md) - Automatically added to codegenerated classes to let them determine their location
- [`SourceLocationAttribute`](./SourceLocationAttribute.md) - Automatically added to classes and their members to let them determine their location

## Interfaces

- [`ICategoryProvider`](./ICategoryProvider.md) - Provides category or group for DisplayInfo of a member or a type.
- [`IClassNameProvider`](./IClassNameProvider.md) - Provides internal class name for DisplayInfo of a member or a type.
- [`IControlSheet`](./IControlSheet.md) - Interface for a control sheet that manages the display of serialized properties in a structured way.
- [`IDescriptionProvider`](./IDescriptionProvider.md) - Provides a description for DisplayInfo of a member or a type.
- [`IFixedUpdateSubscriber`](./IFixedUpdateSubscriber.md) - Automatically added to classes that implement OnFixedUpdate()
- [`IIconProvider`](./IIconProvider.md) - Provides an icon for DisplayInfo of a member or a type.
- [`IMemberNameProvider`](./IMemberNameProvider.md)
- [`IMenuSystem`](./IMenuSystem.md) - This is how the engine communicates with the menu system
- [`IOrderProvider`](./IOrderProvider.md) - Provides an order number for DisplayInfo of a member or a type.
- [`IPanel`](./IPanel.md)
- [`IPlaceholderProvider`](./IPlaceholderProvider.md) - Provides placeholder text for DisplayInfo of a member or a type.
- [`IPreRenderSubscriber`](./IPreRenderSubscriber.md) - Automatically added to classes that implement OnPreRender()
- [`ISourceColumnProvider`](./ISourceColumnProvider.md)
- [`ISourceLineProvider`](./ISourceLineProvider.md)
- [`ISourcePathProvider`](./ISourcePathProvider.md)
- [`ITitleProvider`](./ITitleProvider.md) - Provides a title or a "nice name" for DisplayInfo of a member or a type.
- [`IUpdateSubscriber`](./IUpdateSubscriber.md) - Automatically added to classes that implement OnUpdate()
