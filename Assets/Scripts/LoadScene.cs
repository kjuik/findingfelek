using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private string sceneName;

    [Inject]
    public Fade Fade { set; private get; }

    [Inject]
    public ExplorationState ExplorationState { set; private get; }

    public void Load()
    {
        Fade.Out(() =>
        {
            SceneManager.LoadScene(sceneName);
            ExplorationState.OnLoadScene(sceneName);
        });

    }
}
