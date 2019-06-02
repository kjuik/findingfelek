using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EraseProgress : MonoBehaviour
{
    [Inject]
    public ExplorationState ExplorationState { set; private get; }

    public void Erase() =>
        ExplorationState.OnReset();
}
