using UnityEngine;
using Zenject;

public class ActivateWhenSceneVisited : MonoBehaviour
{
    public string sceneName;

    [Inject]
    public ExplorationState ExplorationState { set; private get; }

    private void OnEnable()
    {
        if (!ExplorationState.HasVisitedScene(sceneName))
            gameObject.SetActive(false);
    }
}
