using System.Collections.Generic;

public class ExplorationState
{
    ExplorationState() { }

    readonly HashSet<string> VisitedScenes = new HashSet<string>();
    readonly HashSet<string> MilestonesReached = new HashSet<string>();

    public void OnLoadScene(string scene) => 
        VisitedScenes.Add(scene);

    public void OnMilestoneReached(string milestone) =>
       MilestonesReached.Add(milestone);

    public void OnReset()
    {
        MilestonesReached.Clear();
        VisitedScenes.Clear();
    }

    public bool HasVisitedScene(string sceneName) => 
        VisitedScenes.Contains(sceneName);

    public bool HasReachedMilestone(string milestone) =>
        MilestonesReached.Contains(milestone);
}
