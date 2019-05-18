using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class LoadScene : MonoBehaviour
{
    public string SceneName;

    [Inject]
    public ExplorationState ExplorationState { set; private get; }

    public void Load()
    {
        SceneManager.LoadScene(SceneName);
        ExplorationState.OnLoadScene(SceneName);
    }
}
