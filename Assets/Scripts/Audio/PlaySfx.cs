using UnityEngine;
using Zenject;

public class PlaySfx : MonoBehaviour
{
    [SerializeField] private AudioManager.Sfx sfx;

    [Inject]
    public AudioManager AudioManager { set; private get; }

    public void Play() =>
        AudioManager.PlaySfx(sfx);
}
