using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Zenject;

public class ActivateWhenMilestoneReached : MonoBehaviour
{
    public string milestoneName;

    [Inject]
    public ExplorationState ExplorationState { set; private get; }

    private void OnEnable()
    {
        if (!ExplorationState.HasReachedMilestone(milestoneName))
            gameObject.SetActive(false);
    }
}
