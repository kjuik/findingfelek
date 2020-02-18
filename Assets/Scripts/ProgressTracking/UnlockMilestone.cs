using UnityEngine;
using Zenject;

public class UnlockMilestone : MonoBehaviour
{
    [SerializeField] private string milestone;

    [Inject]
    public ExplorationState ExplorationState { set; private get; }

    public void Unlock()
    {
        ExplorationState.OnMilestoneReached(milestone);
    }
}
