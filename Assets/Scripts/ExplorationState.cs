using System;
using System.Collections.Generic;
using UnityEngine;

public class ExplorationState
{
    ExplorationState() { }

    readonly HashSet<string> VisitedScenes = new HashSet<string>();

    public void OnLoadScene(string scene) => VisitedScenes.Add(scene);

    public bool HasVisitedScene(string sceneName) => VisitedScenes.Contains(sceneName);
}
