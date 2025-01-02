# F# Immutability Surprise

This example demonstrates a potential pitfall in F#: the immutability of values even when seemingly working with mutable variables.

The code in `bug.fs` shows that the value `z` is calculated once and doesn't reflect later changes to `x` and `y`, even though `x` and `y` are declared mutable. This is because `z` is evaluated and its value is fixed at the time of assignment.  The solution demonstrates the correct approach to achieving the desired dynamic behavior.