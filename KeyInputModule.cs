using AltV.Atlas.KeyInputs.Server.Events;
using Microsoft.Extensions.DependencyInjection;
namespace AltV.Atlas.KeyInputs.Server;

/// <summary>
/// Main entry point to server-side key input module
/// </summary>
public static class KeyInputModule
{
    /// <summary>
    /// Registers the key input module and it's classes/interfaces
    /// </summary>
    /// <param name="serviceCollection">A service collection</param>
    /// <returns>The service collection</returns>
    public static IServiceCollection RegisterKeyInputModule( this IServiceCollection serviceCollection )
    {
        Console.WriteLine( "[ATLAS] KeyInput Module Registered!" );
        serviceCollection.AddSingleton<AtlasKeyInputEvents>( );
        serviceCollection.AddSingleton<PlayerKeyDownEvent>( );
        serviceCollection.AddSingleton<PlayerKeyUpEvent>( );
        
        return serviceCollection;
    }

    /// <summary>
    /// Initializes the key input module
    /// </summary>
    /// <param name="serviceProvider">A service provider</param>
    /// <returns></returns>
    public static IServiceProvider InitializeKeyInputModule( this IServiceProvider serviceProvider )
    {
        Console.WriteLine( "[ATLAS] KeyInput Module Initialized!" );
        _ = serviceProvider.GetService<PlayerKeyDownEvent>( );
        _ = serviceProvider.GetService<PlayerKeyUpEvent>( );
        
        return serviceProvider;
    }
}