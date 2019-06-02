using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class LocalizedText : MonoBehaviour
{
    public string key;

    [Inject]
    public LocalizationManager LocalizationManager { set; private get; }

    private void Awake() =>
        Refresh();

    public void Refresh() =>
        GetComponent<Text>().text = LocalizationManager.GetTranslation(key);

}
