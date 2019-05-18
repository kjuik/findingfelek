using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "ZenjectGlobalInstaller", menuName = "Installers/ZenjectGlobalInstaller")]
public class ZenjectGlobalInstaller : ScriptableObjectInstaller<ZenjectGlobalInstaller>
{
    public override void InstallBindings()
    {
        //Container.Bind<ExplorationState>().AsSingle();
    }
}