using Zenject;

public class ZenjectInstaller : MonoInstaller
{
    public Fade fadeInOutPrefab;
    public AudioManager audioManagerPrefab;
    public LocalizationManager localizationManagerPrefab;

    public override void InstallBindings()
    {
        Container.Bind<Fade>().FromComponentInNewPrefab(fadeInOutPrefab).AsSingle();
        Container.Bind<AudioManager>().FromComponentInNewPrefab(audioManagerPrefab).AsSingle();
        Container.Bind<LocalizationManager>().FromComponentInNewPrefab(localizationManagerPrefab).AsSingle();

        Container.Bind<ExplorationState>().AsSingle(); 
    }
}