using UnityEngine.AddressableAssets;

/// <summary>
/// GameScene을 가지고 있는 ScriptableObject입니다.
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

        GamePlay,
    }
}
