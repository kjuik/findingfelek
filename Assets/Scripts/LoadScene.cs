using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class LoadScene : MonoBehaviour
{
    public string SceneName;

    [Inject]
    public Fade Fade { set; private get; }

    [Inject]
    public ExplorationState ExplorationState { set; private get; }

    public void Load()
    {
        Fade.Out(() =>
        {
            SceneManager.LoadScene(SceneName);
            ExplorationState.OnLoadScene(SceneName);
        });

    }
}
