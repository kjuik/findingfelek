using Zenject;

public class ZenjectInstaller : MonoInstaller
{
    public Fade fadeInOutPrefab;

    public override void InstallBindings()
    {
        Container.Bind<Fade>().FromComponentInNewPrefab(fadeInOutPrefab).AsSingle();
        Container.Bind<ExplorationState>().AsSingle(); 
    }
}