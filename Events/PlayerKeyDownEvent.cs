using AltV.Atlas.KeyInputs.Shared;
using AltV.Atlas.KeyInputs.Shared.Enums;
using AltV.Net;
using AltV.Net.Elements.Entities;
namespace AltV.Atlas.KeyInputs.Server.Events;

public class PlayerKeyDownEvent
{
    private readonly AtlasKeyInputEvents _atlasKeyInputEvents;

    public PlayerKeyDownEvent( AtlasKeyInputEvents atlasKeyInputEvents )
    {
        _atlasKeyInputEvents = atlasKeyInputEvents;
        Alt.OnClient<IPlayer, int>( KeyInputConstants.KeyDownEventName, OnPlayerKeyDown );
    }

    private void OnPlayerKeyDown( IPlayer player, int key ) => _atlasKeyInputEvents.PlayerKeyDown( player, ( AtlasKey ) key );
}