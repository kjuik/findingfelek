using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class SwitchSpriteWhenSceneVisited : MonoBehaviour
{
    public string sceneName;
    public Sprite sprite;

    [Inject]
    public ExplorationState ExplorationState { set; private get; }

    private void OnEnable()
    {
        if (ExplorationState.HasVisitedScene(sceneName))
            gameObject.GetComponent<Image>().sprite = sprite;
    }
}
