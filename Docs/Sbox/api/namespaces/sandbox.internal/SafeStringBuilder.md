# Sandbox.Internal.SafeStringBuilder

Calls to `new StringBuilder()` in addon code will map to this class.
You can use it directly but you probably shouldn't.

- **Kind:** sealed class
- **Namespace:** `Sandbox.Internal`
- **Assembly:** `Sandbox.System`

## Constructors

- `SafeStringBuilder()`
- `SafeStringBuilder(System.Int32 capacity)`
- `SafeStringBuilder(System.Int32 capacity, System.Int32 maxCapacity)`
- `SafeStringBuilder(System.String value)`
- `SafeStringBuilder(System.String value, System.Int32 capacity)`
- `SafeStringBuilder(System.String value, System.Int32 startIndex, System.Int32 length, System.Int32 capacity)`

## Properties

- `System.Int32 Length`
- `System.Int32 Capacity`
- `System.Int32 MaxCapacity`
- `System.Char Item`

## Methods

### Instance methods

- `System.Int32 EnsureCapacity(System.Int32 capacity)`
- `System.Void CopyTo(System.Int32 sourceIndex, System.Char[] destination, System.Int32 destinationIndex, System.Int32 count)`
- `System.Void CopyTo(System.Int32 sourceIndex, System.Span<System.Char> destination, System.Int32 count)`
- `Sandbox.Internal.SafeStringBuilder Clear()`
- `Sandbox.Internal.SafeStringBuilder Remove(System.Int32 startIndex, System.Int32 length)`
- `Sandbox.Internal.SafeStringBuilder Append(System.Boolean value)`
- `Sandbox.Internal.SafeStringBuilder Append(System.Byte value)`
- `Sandbox.Internal.SafeStringBuilder Append(System.Char value)`
- `Sandbox.Internal.SafeStringBuilder Append(System.Char value, System.Int32 repeatCount)`
- `Sandbox.Internal.SafeStringBuilder Append(System.Char[] value)`
- `Sandbox.Internal.SafeStringBuilder Append(System.Char[] value, System.Int32 startIndex, System.Int32 charCount)`
- `Sandbox.Internal.SafeStringBuilder Append(System.Decimal value)`
- `Sandbox.Internal.SafeStringBuilder Append(System.Double value)`
- `Sandbox.Internal.SafeStringBuilder Append(System.Single value)`
- `Sandbox.Internal.SafeStringBuilder Append(System.Int32 value)`
- `Sandbox.Internal.SafeStringBuilder Append(System.Int64 value)`
- `Sandbox.Internal.SafeStringBuilder Append(System.Object value)`
- `Sandbox.Internal.SafeStringBuilder Append(System.ReadOnlyMemory<System.Char> value)`
- `Sandbox.Internal.SafeStringBuilder Append(System.ReadOnlySpan<System.Char> value)`
- `Sandbox.Internal.SafeStringBuilder Append(System.SByte value)`
- `Sandbox.Internal.SafeStringBuilder Append(System.Int16 value)`
- `Sandbox.Internal.SafeStringBuilder Append(System.String value)`
- `Sandbox.Internal.SafeStringBuilder Append(System.String value, System.Int32 startIndex, System.Int32 count)`
- `Sandbox.Internal.SafeStringBuilder Append(System.UInt32 value)`
- `Sandbox.Internal.SafeStringBuilder Append(System.UInt64 value)`
- `Sandbox.Internal.SafeStringBuilder Append(System.UInt16 value)`
- `Sandbox.Internal.SafeStringBuilder Append(Sandbox.Internal.SafeStringBuilder value)`
- `Sandbox.Internal.SafeStringBuilder AppendLine()`
- `Sandbox.Internal.SafeStringBuilder AppendLine(System.String value)`
- `Sandbox.Internal.SafeStringBuilder AppendLine(System.ReadOnlySpan<System.Char> value)`
- `Sandbox.Internal.SafeStringBuilder AppendFormat(System.String format, System.Object arg0)`
- `Sandbox.Internal.SafeStringBuilder AppendFormat(System.String format, System.Object arg0, System.Object arg1)`
- `Sandbox.Internal.SafeStringBuilder AppendFormat(System.String format, System.Object arg0, System.Object arg1, System.Object arg2)`
- `Sandbox.Internal.SafeStringBuilder AppendFormat(System.String format, System.Object[] args)`
- `Sandbox.Internal.SafeStringBuilder AppendFormat(System.IFormatProvider provider, System.String format, System.Object arg0)`
- `Sandbox.Internal.SafeStringBuilder AppendFormat(System.IFormatProvider provider, System.String format, System.Object arg0, System.Object arg1)`
- `Sandbox.Internal.SafeStringBuilder AppendFormat(System.IFormatProvider provider, System.String format, System.Object arg0, System.Object arg1, System.Object arg2)`
- `Sandbox.Internal.SafeStringBuilder AppendFormat(System.IFormatProvider provider, System.String format, System.Object[] args)`
- `Sandbox.Internal.SafeStringBuilder AppendJoin(System.Char separator, System.Collections.Generic.IEnumerable<T> values)`
- `Sandbox.Internal.SafeStringBuilder AppendJoin(System.String separator, System.Collections.Generic.IEnumerable<T> values)`
- `Sandbox.Internal.SafeStringBuilder AppendJoin(System.Char separator, System.Object[] values)`
- `Sandbox.Internal.SafeStringBuilder AppendJoin(System.Char separator, System.String[] values)`
- `Sandbox.Internal.SafeStringBuilder AppendJoin(System.String separator, System.Object[] values)`
- `Sandbox.Internal.SafeStringBuilder AppendJoin(System.String separator, System.String[] values)`
- `Sandbox.Internal.SafeStringBuilder Insert(System.Int32 index, System.Boolean value)`
- `Sandbox.Internal.SafeStringBuilder Insert(System.Int32 index, System.Byte value)`
- `Sandbox.Internal.SafeStringBuilder Insert(System.Int32 index, System.Char value)`
- `Sandbox.Internal.SafeStringBuilder Insert(System.Int32 index, System.Char[] value)`
- `Sandbox.Internal.SafeStringBuilder Insert(System.Int32 index, System.Char[] value, System.Int32 startIndex, System.Int32 charCount)`
- `Sandbox.Internal.SafeStringBuilder Insert(System.Int32 index, System.Decimal value)`
- `Sandbox.Internal.SafeStringBuilder Insert(System.Int32 index, System.Double value)`
- `Sandbox.Internal.SafeStringBuilder Insert(System.Int32 index, System.Single value)`
- `Sandbox.Internal.SafeStringBuilder Insert(System.Int32 index, System.Int32 value)`
- `Sandbox.Internal.SafeStringBuilder Insert(System.Int32 index, System.Int64 value)`
- `Sandbox.Internal.SafeStringBuilder Insert(System.Int32 index, System.Object value)`
- `Sandbox.Internal.SafeStringBuilder Insert(System.Int32 index, System.ReadOnlySpan<System.Char> value)`
- `Sandbox.Internal.SafeStringBuilder Insert(System.Int32 index, System.SByte value)`
- `Sandbox.Internal.SafeStringBuilder Insert(System.Int32 index, System.Int16 value)`
- `Sandbox.Internal.SafeStringBuilder Insert(System.Int32 index, System.String value)`
- `Sandbox.Internal.SafeStringBuilder Insert(System.Int32 index, System.String value, System.Int32 count)`
- `Sandbox.Internal.SafeStringBuilder Insert(System.Int32 index, System.UInt32 value)`
- `Sandbox.Internal.SafeStringBuilder Insert(System.Int32 index, System.UInt64 value)`
- `Sandbox.Internal.SafeStringBuilder Insert(System.Int32 index, System.UInt16 value)`
- `Sandbox.Internal.SafeStringBuilder Replace(System.Char oldChar, System.Char newChar)`
- `Sandbox.Internal.SafeStringBuilder Replace(System.Char oldChar, System.Char newChar, System.Int32 startIndex, System.Int32 count)`
- `Sandbox.Internal.SafeStringBuilder Replace(System.String oldValue, System.String newValue)`
- `Sandbox.Internal.SafeStringBuilder Replace(System.String oldValue, System.String newValue, System.Int32 startIndex, System.Int32 count)`
