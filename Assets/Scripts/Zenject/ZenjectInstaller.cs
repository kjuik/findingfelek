using UnityEngine;
using Zenject;

public class ZenjectInstaller : MonoInstaller
{
    [SerializeField] private Fade fadeInOutPrefab;
    [SerializeField] private AudioManager audioManagerPrefab;
    [SerializeField] private LocalizationManager localizationManagerPrefab;

    public override void InstallBindings()
    {
        Container.Bind<Fade>().FromComponentInNewPrefab(fadeInOutPrefab).AsSingle();
        Container.Bind<AudioManager>().FromComponentInNewPrefab(audioManagerPrefab).AsSingle();
        Container.Bind<LocalizationManager>().FromComponentInNewPrefab(localizationManagerPrefab).AsSingle();

        Container.Bind<ExplorationState>().AsSingle(); 
    }
}