using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public enum Sfx
    {
        Click, Car, Train, Plane
    }

    public enum Loop
    {
        GameMusic, EndMusic
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

    public List<SfxAudio> sfxAudios;
    public List<LoopAudio> loopAudios;

    public AudioMixerGroup sfxGroup;
    public AudioMixerGroup loopGroup;

    public AudioSource audioSourcePrefab;

    AudioSource currentLoop;

    private void Awake()
    {
        currentLoop = Instantiate(audioSourcePrefab, transform);
        currentLoop.loop = true;
        currentLoop.clip = loopAudios.First().clip;
        currentLoop.outputAudioMixerGroup = loopGroup;
        currentLoop.Play();
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
        currentLoop.clip = loopAudios.First(x => x.key == loop).clip;
        currentLoop.Play();
    }
}
