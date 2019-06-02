using System.Collections.Generic;

public class ExplorationState
{
    ExplorationState() { }

    readonly HashSet<string> VisitedScenes = new HashSet<string>();
    readonly HashSet<string> MilestonesReached = new HashSet<string>();
    readonly HashSet<string> MilestonesAnimated = new HashSet<string>();

    public void OnLoadScene(string scene) => 
        VisitedScenes.Add(scene);

    public void OnMilestoneReached(string milestone) =>
       MilestonesReached.Add(milestone);

    public void OnMilestoneAnimated(string milestone) =>
       MilestonesAnimated.Add(milestone);

    public void OnReset()
    {
        VisitedScenes.Clear();
        MilestonesReached.Clear();
        MilestonesAnimated.Clear();
    }

    public bool HasVisitedScene(string sceneName) => 
        VisitedScenes.Contains(sceneName);

    public bool HasReachedMilestone(string milestone) =>
        MilestonesReached.Contains(milestone);

    public bool HasAnimatedMilestone(string milestone) =>
        MilestonesAnimated.Contains(milestone);
}
