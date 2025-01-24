# F# Mutable Variable and Reference Bug

This example demonstrates a potential misunderstanding in F# regarding mutable variables and references.

## Problem

In F#, when you create a reference to a mutable variable, modifying the variable doesn't automatically update the reference.  The reference holds the *value* at the time of creation, not a live pointer.

## Solution

To update a reference to reflect changes in a mutable variable, you need to explicitly dereference the reference and assign the new value using the dereference operator (`!`).