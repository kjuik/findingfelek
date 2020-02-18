using UnityEngine;
using Zenject;

public class ActivateInLanguage : MonoBehaviour
{
    [SerializeField] private string language;

    [Inject]
    public LocalizationManager LocalizationManager { set; private get; }

    private void OnEnable()
    {
        if (LocalizationManager.CurrentLanguage != language)
            gameObject.SetActive(false);
    }
}
