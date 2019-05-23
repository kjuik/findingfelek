using UnityEngine;
using Zenject;

public class PlaySfx : MonoBehaviour
{
    public AudioManager.Sfx Sfx;

    [Inject]
    public AudioManager AudioManager { set; private get; }

    public void Play() =>
        AudioManager.PlaySfx(Sfx);
}
