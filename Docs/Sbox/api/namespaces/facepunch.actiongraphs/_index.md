# Namespace `Facepunch.ActionGraphs`

100 types.

## Classes

- [`AccessorNodeDefinition<T>`](./AccessorNodeDefinition-T.md) - Base class for nodes that get / set values.
- [`ActionGraph`](./ActionGraph.md) - Represents an async method as a directed graph. Control will enter through an "event" node, which
- [`ActionGraphCache`](./ActionGraphCache.md) - Used to re-use `Facepunch.ActionGraphs.ActionGraph` instances when deserializing.
- [`ActionGraphDelegate<T>`](./ActionGraphDelegate-T.md) - Wrapper for an `Facepunch.ActionGraphs.ActionGraph` invokable as a delegate, with optional overridden input values.
- [`AddAssemblyResult`](./AddAssemblyResult.md) - Returned by `Facepunch.ActionGraphs.NodeLibrary.AddAssembly(System.Reflection.Assembly)`.
- [`AssignmentKind`](./AssignmentKind.md) - Operations accessor nodes can perform.
- [`BindingSurface`](./BindingSurface.md)
- [`Constant`](./Constant.md)
- [`CreateSubGraphNodeDelegate`](./CreateSubGraphNodeDelegate.md)
- [`CreateSubGraphResult`](./CreateSubGraphResult.md)
- [`DefaultGraphLoader`](./DefaultGraphLoader.md)
- [`DefaultTypeLoader`](./DefaultTypeLoader.md) - A default implementation of `Facepunch.ActionGraphs.ITypeLoader` with no access control.
- [`DisplayInfo`](./DisplayInfo.md) - Display information of a `Facepunch.ActionGraphs.NodeDefinition`.
- [`Either<T1,T2,T3,T4,T5,T6,T7,TRest>`](./Either-T1,T2,T3,T4,T5,T6,T7,TRest.md)
- [`Either<T1,T2,T3,T4,T5,T6,T7>`](./Either-T1,T2,T3,T4,T5,T6,T7.md)
- [`Either<T1,T2,T3,T4,T5,T6>`](./Either-T1,T2,T3,T4,T5,T6.md)
- [`Either<T1,T2,T3,T4,T5>`](./Either-T1,T2,T3,T4,T5.md)
- [`Either<T1,T2,T3,T4>`](./Either-T1,T2,T3,T4.md)
- [`Either<T1,T2,T3>`](./Either-T1,T2,T3.md)
- [`Either<T1,T2>`](./Either-T1,T2.md)
- [`FileSystemGraphLoader`](./FileSystemGraphLoader.md)
- [`GetNodeLibraryDelegate`](./GetNodeLibraryDelegate.md)
- [`Input<T>`](./Input-T.md) - Helper type for input parameters of methods marked with `Facepunch.ActionGraphs.NodeAttribute`.
- [`InputDefinition`](./InputDefinition.md) - Describes an input of a node.
- [`InputFlags`](./InputFlags.md)
- [`InsertResult`](./InsertResult.md) - Elements added by a call to `!:IActionGraph.DeserializeInsert`.
- [`Link`](./Link.md) - A link connects one `Facepunch.ActionGraphs.Node.Input` to a `Facepunch.ActionGraphs.Node.Output`.
- [`LinkTriggeredHandler`](./LinkTriggeredHandler.md) - Handler for `Facepunch.ActionGraphs.ActionGraph.LinkTriggered` events.
- [`MessageLevel`](./MessageLevel.md) - Severity level of a validation message.
- [`MethodBinder`](./MethodBinder.md)
- [`MethodCallNodeDefinition`](./MethodCallNodeDefinition.md)
- [`NewInstanceNodeDefinition`](./NewInstanceNodeDefinition.md)
- [`Node`](./Node.md) - The main building block of an action graph. Represents either an action or expression.
- [`NodeBinding`](./NodeBinding.md) - A collection of named node properties, inputs, and outputs with specific types, as
- [`NodeDefinition`](./NodeDefinition.md) - Describes the behaviour and bindings of a node for use in an action graph.
- [`NodeInputs`](./NodeInputs.md) - Named inputs of a node, that may either link to the outputs of other nodes,
- [`NodeKind`](./NodeKind.md) - Nodes can be lazily evaluated expression without any signals,
- [`NodeLibrary`](./NodeLibrary.md) - Contains a library of `Facepunch.ActionGraphs.NodeDefinition`s, each with a unique identifier.
- [`NodeOutputs`](./NodeOutputs.md) - Named outputs of a node, that may link to the inputs of other nodes.
- [`NodeParameters<T>`](./NodeParameters-T.md)
- [`NodeProperties`](./NodeProperties.md) - Constant named values stored in a node.
- [`Null`](./Null.md) - Represents a null reference.
- [`ObjectConverter`](./ObjectConverter.md)
- [`OutputDefinition`](./OutputDefinition.md) - Describes an output of a node.
- [`OutputFlags`](./OutputFlags.md)
- [`ParameterFlags`](./ParameterFlags.md)
- [`PropertyDefinition`](./PropertyDefinition.md) - Describes a property of a node that should be configurable in the inspector.
- [`PropertyFlags`](./PropertyFlags.md)
- [`SerializationOptions`](./SerializationOptions.md) - Controls how `Facepunch.ActionGraphs.ActionGraph`s are (de)serialized.
- [`TypeConverter`](./TypeConverter.md)
- [`ValidationException`](./ValidationException.md) - Exception thrown when an invalid action graph is invoked.
- [`ValidationMessage`](./ValidationMessage.md) - A message generated during validation with a context, level, and value.
- [`Variable`](./Variable.md) - Variables have a name and type, and are local to each invocation of an `Facepunch.ActionGraphs.Variable.ActionGraph`.
- [`VoidTaskFaultHandler`](./VoidTaskFaultHandler.md)

## Static classes

- [`ActionGraphExtensions`](./ActionGraphExtensions.md) - Extension methods for action graphs.
- [`DelegateExtensions`](./DelegateExtensions.md)
- [`Either`](./Either.md)
- [`JsonExtensions`](./JsonExtensions.md) - Extension methods for `System.Text.Json` types.
- [`ParameterDefinitionExtensions`](./ParameterDefinitionExtensions.md)
- [`ParameterNames`](./ParameterNames.md) - Special names for parameters of built-in node types.
- [`ReflectionExtensions`](./ReflectionExtensions.md)
- [`Signal`](./Signal.md) - Node inputs and outputs of this type will transmit signals rather than values.
- [`ValidationExtensions`](./ValidationExtensions.md) - Extension methods related to validation and validation messages.

## Attributes

- [`AlwaysInvokedAttribute`](./AlwaysInvokedAttribute.md)
- [`DescriptionAttribute`](./DescriptionAttribute.md)
- [`ExposeWhenCachedAttribute`](./ExposeWhenCachedAttribute.md)
- [`GroupAttribute`](./GroupAttribute.md)
- [`HiddenAttribute`](./HiddenAttribute.md)
- [`IconAttribute`](./IconAttribute.md)
- [`ImpureAttribute`](./ImpureAttribute.md)
- [`NodeAttribute`](./NodeAttribute.md)
- [`NodeDefinitionAttribute`](./NodeDefinitionAttribute.md)
- [`PropertyAttribute`](./PropertyAttribute.md)
- [`PureAttribute`](./PureAttribute.md)
- [`TagsAttribute`](./TagsAttribute.md)
- [`TargetAttribute`](./TargetAttribute.md)
- [`TitleAttribute`](./TitleAttribute.md)

## Interfaces

- [`IActionGraphCache`](./IActionGraphCache.md)
- [`IActionGraphDelegate`](./IActionGraphDelegate.md) - Wrapper for an `Facepunch.ActionGraphs.ActionGraph` invokable as a delegate, with optional overridden input values.
- [`IAlwaysInvokedAttribute`](./IAlwaysInvokedAttribute.md) - Marks an output signal that will always be dispatched before the default output
- [`IDescriptionAttribute`](./IDescriptionAttribute.md)
- [`IExposeWhenCachedAttribute`](./IExposeWhenCachedAttribute.md) - Declares that instances of the marked type can't be cached in a `Facepunch.ActionGraphs.ActionGraphCache`.
- [`IGraphLoader`](./IGraphLoader.md)
- [`IGroupAttribute`](./IGroupAttribute.md)
- [`IHiddenAttribute`](./IHiddenAttribute.md)
- [`IIconAttribute`](./IIconAttribute.md)
- [`IImpureAttribute`](./IImpureAttribute.md) - Declares a method to have side effects, even if it's declared as
- [`ILinkSource`](./ILinkSource.md)
- [`IMessageContext`](./IMessageContext.md) - Interface for action graph elements that can be the context of a `Facepunch.ActionGraphs.ValidationMessage`.
- [`INodeAttribute`](./INodeAttribute.md) - Used to define ActionGraph nodes using static methods, properties, or constructors.
- [`INodeContainer`](./INodeContainer.md)
- [`INodeDefinitionAttribute`](./INodeDefinitionAttribute.md) - Marks a class extending `Facepunch.ActionGraphs.NodeDefinition` that should be automatically
- [`IParameterDefinition`](./IParameterDefinition.md) - Base interface for `Facepunch.ActionGraphs.PropertyDefinition`, `Facepunch.ActionGraphs.InputDefinition` and
- [`IPropertyAttribute`](./IPropertyAttribute.md) - For binding in methods marked with a `Facepunch.ActionGraphs.NodeAttribute`, this parameter should only
- [`IPureAttribute`](./IPureAttribute.md) - Declares a method to not have any side effects, it only performs a calculation
- [`ISourceLocation`](./ISourceLocation.md) - Interface for types that identify the source of an `Facepunch.ActionGraphs.ActionGraph`.
- [`ITagsAttribute`](./ITagsAttribute.md)
- [`ITargetAttribute`](./ITargetAttribute.md) - For binding in methods marked with a `Facepunch.ActionGraphs.NodeAttribute`, this parameter represents
- [`ITitleAttribute`](./ITitleAttribute.md)
- [`ITypeLoader`](./ITypeLoader.md) - An implementation of this interface will wrap reflection calls, allowing

## Structs

- [`Constant`](./Constant.md)
- [`CreateSubGraphResult`](./CreateSubGraphResult.md)
- [`InsertResult`](./InsertResult.md) - Elements added by a call to `!:IActionGraph.DeserializeInsert`.
- [`Null`](./Null.md) - Represents a null reference.
- [`ValidationMessage`](./ValidationMessage.md) - A message generated during validation with a context, level, and value.

## Enums

- [`AssignmentKind`](./AssignmentKind.md) - Operations accessor nodes can perform.
- [`InputFlags`](./InputFlags.md)
- [`MessageLevel`](./MessageLevel.md) - Severity level of a validation message.
- [`NodeKind`](./NodeKind.md) - Nodes can be lazily evaluated expression without any signals,
- [`OutputFlags`](./OutputFlags.md)
- [`ParameterFlags`](./ParameterFlags.md)
- [`PropertyFlags`](./PropertyFlags.md)
