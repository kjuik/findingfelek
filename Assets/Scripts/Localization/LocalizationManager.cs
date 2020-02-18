using System.Collections.Generic;
using UnityEngine;

public class LocalizationManager : MonoBehaviour
{
    [SerializeField] private string defaultLanguage = "pl-pl";
    [SerializeField] private char newlineEscapeChar = '^';

    public TextAsset translationsCsv;

    private readonly Dictionary<string, Dictionary<string, string>> _translations 
        = new Dictionary<string, Dictionary<string, string>>();

    public string CurrentLanguage { get; private set; }

    private void Awake()
    {
        PopulateTranslations(ParseCsv());
        SetLanguage(defaultLanguage);
    }

    private string[][] ParseCsv()
    {
        var rows = translationsCsv.text.Replace("\r\n", "§").Split('§');

        var cells = new string[rows.Length][];
        for (var i = 0; i < rows.Length; i++)
            cells[i] = rows[i].Replace(newlineEscapeChar, '\n').Split(';');

        return cells;
    }

    private void PopulateTranslations(string[][] cells)
    {
        for (var i=1; i<cells.Length; i++)
        {
            var currentPhrase = new Dictionary<string, string>();

            for (var j=1; j<cells[i].Length; j++)
                currentPhrase[cells[0][j]] = cells[i][j];

            _translations[cells[i][0]] = currentPhrase;
        }
    }

    public void SetLanguage(string language) => 
        CurrentLanguage = language;

    public string GetTranslation(string key) => 
        _translations[key][CurrentLanguage];
}
