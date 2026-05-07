# Namespace `Sandbox.ActionGraphs`

22 types.

## Classes

- [`ActionGraphResource`](./ActionGraphResource.md) - Some game logic implemented using visual scripting
- [`ActionsInvoker`](./ActionsInvoker.md) - A component which allows you to use action in all the usual functions.
- [`AwakeActionComponent`](./AwakeActionComponent.md)
- [`CollisionActionComponent`](./CollisionActionComponent.md) - Reacts to collisions.
- [`DestroyActionComponent`](./DestroyActionComponent.md)
- [`DisabledActionComponent`](./DisabledActionComponent.md)
- [`EnabledActionComponent`](./EnabledActionComponent.md)
- [`FixedUpdateActionComponent`](./FixedUpdateActionComponent.md)
- [`GameResourceSourceLocation`](./GameResourceSourceLocation.md) - Source location for action graphs that belong to a `Sandbox.GameResource`.
- [`MapSourceLocation`](./MapSourceLocation.md) - Source location for action graphs that belong to a Hammer map. This is used for stack
- [`SceneReferenceNode`](./SceneReferenceNode.md) - An `Facepunch.ActionGraphs.Node` from an `Facepunch.ActionGraphs.ActionGraph` that references a
- [`SceneReferenceTriggeredEvent`](./SceneReferenceTriggeredEvent.md)
- [`SimpleActionComponent`](./SimpleActionComponent.md) - These should not exist
- [`StartActionComponent`](./StartActionComponent.md)
- [`TriggerActionComponent`](./TriggerActionComponent.md) - Reacts to collider triggers.
- [`UpdateActionComponent`](./UpdateActionComponent.md)

## Static classes

- [`ActionGraphEditorExtensions`](./ActionGraphEditorExtensions.md) - Helper methods for action graph editor tools. Mostly workaround for `Sandbox.GameObjectReference`
- [`ActionGraphExtensions`](./ActionGraphExtensions.md)

## Attributes

- [`HasConversionFromAttribute`](./HasConversionFromAttribute.md)

## Interfaces

- [`IActionComponent`](./IActionComponent.md) - A component that only provides actions to implement with an Action Graph.
- [`IActionGraphEvents`](./IActionGraphEvents.md)
- [`ISerializationOptionProvider`](./ISerializationOptionProvider.md) - A `Facepunch.ActionGraphs.ISourceLocation` that provides `Facepunch.ActionGraphs.SerializationOptions`.

## Structs

- [`SceneReferenceNode`](./SceneReferenceNode.md) - An `Facepunch.ActionGraphs.Node` from an `Facepunch.ActionGraphs.ActionGraph` that references a
- [`SceneReferenceTriggeredEvent`](./SceneReferenceTriggeredEvent.md)
