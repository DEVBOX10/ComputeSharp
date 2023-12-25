#pragma warning disable CS0660, CS0661

namespace ComputeSharp;

/// <summary>
/// A <see langword="struct"/> that maps the <see langword="int4"/> HLSL type.
/// </summary>
public partial struct Int4
{
    /// <summary>
    /// Creates a new <see cref="Int4"/> value with the same value for all its components.
    /// </summary>
    /// <param name="x">The value to use for the components of the new <see cref="Int4"/> instance.</param>
    public static implicit operator Int4(int x) => new(x, x, x, x);

    /// <summary>
    /// Casts a <see cref="Int4"/> value to a <see cref="UInt4"/> one.
    /// </summary>
    /// <param name="xyzw">The input <see cref="Int4"/> value to cast.</param>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static explicit operator UInt4(Int4 xyzw) => default;

    /// <summary>
    /// Casts a <see cref="Int4"/> value to a <see cref="Float4"/> one.
    /// </summary>
    /// <param name="xyzw">The input <see cref="Int4"/> value to cast.</param>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static implicit operator Float4(Int4 xyzw) => default;

    /// <summary>
    /// Casts a <see cref="Int4"/> value to a <see cref="Double4"/> one.
    /// </summary>
    /// <param name="xyzw">The input <see cref="Int4"/> value to cast.</param>
    /// <remarks>This method is an intrinsic and can only be used within a shader on the GPU. Using it on the CPU is undefined behavior.</remarks>
    public static implicit operator Double4(Int4 xyzw) => default;
}