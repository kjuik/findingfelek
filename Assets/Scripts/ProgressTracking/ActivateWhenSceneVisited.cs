using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Zenject;

public class ActivateWhenSceneVisited : MonoBehaviour
{
    [SerializeField] private List<string> sceneNames;

    [Inject]
    public ExplorationState ExplorationState { set; private get; }

    private void OnEnable()
    {
        if (sceneNames.Any(scene => !ExplorationState.HasVisitedScene(scene)))
            gameObject.SetActive(false);
    }
}
