using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    Image image;

    private void Awake() =>
        image = GetComponentInChildren<Image>().OrThrow();

    public void In(Action onFinished = null)
    {
        StopAllCoroutines();
        StartCoroutine(Run(1f, 0f, onFinished: onFinished));
    }

    public void Out(Action onFinished = null)
    {
        StopAllCoroutines();
        StartCoroutine(Run(0f, 1f, onFinished: onFinished));
    }

    private IEnumerator Run(float from, float to, float duration = .25f, Action onFinished = null)
    {
        var startTimestamp = Time.time;
        while (Time.time - startTimestamp < duration)
        {
            image.color = new Color(
                image.color.r,
                image.color.g,
                image.color.b,
                Mathf.Lerp(from, to, (Time.time - startTimestamp) / duration));

            yield return null;
        }

        onFinished?.Invoke();
            
    }
}
