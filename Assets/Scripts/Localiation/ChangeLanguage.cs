using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ChangeLanguage : MonoBehaviour
{
    public string language;

    [Inject]
    public LocalizationManager LocalizationManager { set; private get; }

    public void Change() =>
        LocalizationManager.SetLanguage(language);
}
