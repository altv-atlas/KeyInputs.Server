using AltV.Atlas.KeyInputs.Shared;
using AltV.Atlas.KeyInputs.Shared.Enums;
using AltV.Net;
using AltV.Net.Elements.Entities;
namespace AltV.Atlas.KeyInputs.Server.Events;

public class PlayerKeyUpEvent
{
    private readonly AtlasKeyInputEvents _atlasKeyInputEvents;

    public PlayerKeyUpEvent( AtlasKeyInputEvents atlasKeyInputEvents )
    {
        _atlasKeyInputEvents = atlasKeyInputEvents;
        Alt.OnClient<IPlayer, int>( KeyInputConstants.KeyUpEventName, OnPlayerKeyDown );
    }

    private void OnPlayerKeyDown( IPlayer player, int key ) => _atlasKeyInputEvents.PlayerKeyUp( player, ( AtlasKey ) key );
}