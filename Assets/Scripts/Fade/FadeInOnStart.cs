using UnityEngine;
using Zenject;

public class FadeInOnStart : MonoBehaviour
{
    [Inject]
    public Fade Fade { set; private get; }

    private void Start() => 
        Fade.In();
}
