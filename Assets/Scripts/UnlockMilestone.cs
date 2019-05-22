using UnityEngine;
using Zenject;

public class UnlockMilestone : MonoBehaviour
{
    public string Milestone;

    [Inject]
    public ExplorationState ExplorationState { set; private get; }

    public void Unlock()
    {
        ExplorationState.OnMilestoneReached(Milestone);
    }
}
