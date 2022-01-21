using UnityEngine.AddressableAssets;

/// <summary>
/// Game에 Scene을 가지고 있는
/// </summary>
public class GameSceneSO : DescriptionBaseSO
{
    public GameSceneType sceneType;
    public AssetReference sceneReference;

    public enum GameSceneType
    {
        // Special scenes
        Initialization,
        PersistantMangers,

        // Playable Scenes
        Menu,
        Location,

        // Work in progress scenes that don't need to be played Art
        Art,
    }
}
