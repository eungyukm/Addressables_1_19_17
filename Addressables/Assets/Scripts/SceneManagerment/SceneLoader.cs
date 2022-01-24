using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 01. Scene을 Load하는 SceneLoad Manager입니다.
/// 02. 다음 씬을 로드하기 위한 GameSceneSO를 생성합니다.
/// 03. Scene을 LoadEventChannelSO를 생성합니다.
/// 04. VoidEventChannel을 생성합니다.
/// 05. SceneLoad 준비가 완료되었다는 Broadcasting EventChannel ScriptableObject를 생성합니다.
/// </summary>
public class SceneLoader : MonoBehaviour
{
    private GameSceneSO sceneToLoad;
    private GameSceneSO currentlyLoadScene;

    [Header("Listening to")]
    [SerializeField] private LoadEventChannelSO loadLocation = default;
    [SerializeField] private LoadEventChannelSO loadMenu = default;

    [Header("Broadcasting on")]
    [SerializeField] private VoidEventChannelSO onSceneReady = default;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
