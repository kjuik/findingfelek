using System.Collections.Generic;

public class ExplorationState
{
    private ExplorationState() { }

    private readonly HashSet<string> _visitedScenes = new HashSet<string>();
    private readonly HashSet<string> _milestonesReached = new HashSet<string>();
    private readonly HashSet<string> _milestonesAnimated = new HashSet<string>();

    public void OnLoadScene(string scene) => 
        _visitedScenes.Add(scene);

    public void OnMilestoneReached(string milestone) =>
       _milestonesReached.Add(milestone);

    public void OnMilestoneAnimated(string milestone) =>
       _milestonesAnimated.Add(milestone);

    public void OnReset()
    {
        _visitedScenes.Clear();
        _milestonesReached.Clear();
        _milestonesAnimated.Clear();
    }

    public bool HasVisitedScene(string sceneName) => 
        _visitedScenes.Contains(sceneName);

    public bool HasReachedMilestone(string milestone) =>
        _milestonesReached.Contains(milestone);

    public bool HasAnimatedMilestone(string milestone) =>
        _milestonesAnimated.Contains(milestone);
}
