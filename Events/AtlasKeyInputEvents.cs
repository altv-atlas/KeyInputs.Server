using AltV.Atlas.KeyInputs.Shared.Enums;
using AltV.Net.Elements.Entities;
namespace AltV.Atlas.KeyInputs.Server.Events;

/// <summary>
/// Class that receives and emits events that occur within the key input module
/// </summary>
public class AtlasKeyInputEvents
{
    #region PlayerKeyDown

    /// <summary>
    /// Delegate
    /// </summary>
    public delegate void PlayerKeyDownDelegate( IPlayer player, AtlasKey key );

    /// <summary>
    /// Triggers when a player triggers a key down event client-side
    /// </summary>
    public event PlayerKeyDownDelegate? OnPlayerKeyDown;

    /// <summary>
    /// Event that triggers when a player triggers a key down event client-side
    /// </summary>
    /// <param name="player">The player who triggered the key down</param>
    /// <param name="key">The key which was pressed</param>
    public void PlayerKeyDown( IPlayer player, AtlasKey key )
    {
        OnPlayerKeyDown?.Invoke( player, key );
    }

    #endregion

    #region PlayerKeyUp

    /// <summary>
    /// Delegate
    /// </summary>
    public delegate void PlayerKeyUpDelegate( IPlayer player, AtlasKey key );

    /// <summary>
    /// Triggers when a player triggers a key up event client-side
    /// </summary>
    public event PlayerKeyUpDelegate? OnPlayerKeyUp;

    /// <summary>
    /// Event that triggers when a player triggers a key up event client-side
    /// </summary>
    /// <param name="player">The player who triggered the key up</param>
    /// <param name="key">The key which was pressed</param>
    public void PlayerKeyUp( IPlayer player, AtlasKey key )
    {
        OnPlayerKeyUp?.Invoke( player, key );
    }

    #endregion
}