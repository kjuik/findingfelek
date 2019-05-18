using System.Collections.Generic;

public class ExplorationState
{
    ExplorationState() { }

    readonly HashSet<string> VisitedScenes = new HashSet<string>();

    public void OnLoadScene(string scene) => VisitedScenes.Add(scene);

    public bool HasVisitedScene(string sceneName) => VisitedScenes.Contains(sceneName);
}
