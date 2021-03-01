using System;

namespace MythicTracker
{
    /// <summary>
    /// The enumeration of possible modifiers.
    /// </summary>
    [Flags]
    public enum ModiferKey
    {
        Alt = 1,
        Control = 2,
        Shift = 4,
        Win = 8
    }
}