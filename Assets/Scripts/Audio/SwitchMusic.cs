using UnityEngine;
using Zenject;

public class SwitchMusic : MonoBehaviour
{
    [SerializeField] private AudioManager.Loop music;

    [Inject]
    public AudioManager AudioManager { set; private get; }

    public void Switch() =>
        AudioManager.ChangeLoop(music);
}
