using UnityEngine;

public class BackgroundAudio : MonoBehaviour
{
    void Start() =>
        DontDestroyOnLoad(gameObject);
}
