using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SwitchMusic : MonoBehaviour
{
    public AudioManager.Loop Music;

    [Inject]
    public AudioManager AudioManager { set; private get; }

    public void Switch() =>
        AudioManager.ChangeLoop(Music);
}
