/*
We are implementing this as a struct rather than a class because SlimeSegment is a small, simple data container with value semantics. 
Structs are more efficient for small data structures since they are allocated on the stack rather than the heap, reducing garbage 
collection overhead. Since our game will potentially create many segments as the snake grows, using a struct can provide better performance, 
especially when we will be copying segment data during movement operations.

Structs work best with value types (like int, float, Vector2); using reference types in structs can cause boxing operations that negate the 
performance benefits. For more information on structs, refer to the Structure Types - C# Reference documentation on Microsoft Learn.
*/

using Microsoft.Xna.Framework;

namespace DungeonSlime.GameObjects;

public struct SlimeSegment
{
    /// <summary>
    /// The position this slime segment is at before the movement cycle occurs.
    /// </summary>
    public Vector2 At;

    /// <summary>
    /// The position this slime segment should move to during the next movement cycle.
    /// </summary>
    public Vector2 To;

    /// <summary>
    /// The direction this slime segment is moving.
    /// </summary>
    public Vector2 Direction;

    /// <summary>
    /// The opposite direction this slime segment is moving.
    /// </summary>
    public Vector2 ReverseDirection => new Vector2(-Direction.X, -Direction.Y);
}
