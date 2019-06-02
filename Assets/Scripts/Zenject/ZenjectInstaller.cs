using Zenject;

public class ZenjectInstaller : MonoInstaller
{
    public Fade fadeInOutPrefab;
    public AudioManager audioManagerPrefab;

    public override void InstallBindings()
    {
        Container.Bind<Fade>().FromComponentInNewPrefab(fadeInOutPrefab).AsSingle();
        Container.Bind<AudioManager>().FromComponentInNewPrefab(audioManagerPrefab).AsSingle();

        Container.Bind<ExplorationState>().AsSingle(); 
    }
}