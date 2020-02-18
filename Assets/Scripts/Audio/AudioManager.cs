using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public enum Sfx
    {
        Click,
        Car, 
        Train, 
        Plane
    }

    public enum Loop
    {
        GameMusic, 
        EndMusic
    }

    [System.Serializable]
    public struct SfxAudio
    {
        public Sfx key;
        public List<AudioClip> clips;
    }

    [System.Serializable]
    public struct LoopAudio
    {
        public Loop key;
        public AudioClip clip;
    }

    [SerializeField] private List<SfxAudio> sfxAudios;
    [SerializeField] private List<LoopAudio> loopAudios;

    [SerializeField] private AudioMixerGroup sfxGroup;
    [SerializeField] private AudioMixerGroup loopGroup;

    [SerializeField] private AudioSource audioSourcePrefab;

    private AudioSource _currentLoop;

    private void Awake()
    {
        _currentLoop = Instantiate(audioSourcePrefab, transform);
        _currentLoop.loop = true;
        _currentLoop.clip = loopAudios.First().clip;
        _currentLoop.outputAudioMixerGroup = loopGroup;
        _currentLoop.Play();
    }

    public void PlaySfx(Sfx sfx)
    {
        var source = Instantiate(audioSourcePrefab, transform);
        var sfxAudio = sfxAudios.First(x => x.key == sfx);
        source.clip = sfxAudio.clips[Random.Range(0, sfxAudio.clips.Count-1)];
        source.outputAudioMixerGroup = sfxGroup;
        source.Play();
        Destroy(source.gameObject, source.clip.length);
    }

    public void ChangeLoop(Loop loop)
    {
        _currentLoop.clip = loopAudios.First(x => x.key == loop).clip;
        _currentLoop.Play();
    }
}
