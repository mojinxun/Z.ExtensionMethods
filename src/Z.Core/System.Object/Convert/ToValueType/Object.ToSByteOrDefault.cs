// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright ?ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;

public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that converts this object to the s byte or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to a sbyte.</returns>
    public static sbyte ToSByteOrDefault(this object @this)
    {
        try
        {
            return Convert.ToSByte(@this);
        }
        catch (Exception)
        {
            return default(sbyte);
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to the s byte or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to a sbyte.</returns>
    public static sbyte ToSByteOrDefault(this object @this, sbyte defaultValue)
    {
        try
        {
            return Convert.ToSByte(@this ?? "");
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to the s byte or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to a sbyte.</returns>
    public static sbyte ToSByteOrDefault(this object @this, Func<sbyte> defaultValueFactory)
    {
        try
        {
            return Convert.ToSByte(@this ?? "");
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }
}