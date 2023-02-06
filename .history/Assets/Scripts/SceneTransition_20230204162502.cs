using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using Yarn.Unity;

public class SceneTransition : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public GameObject console;
    public Dialog

    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        Debug.Log("canvasGroup.alpha: " + canvasGroup.alpha);
        canvasGroup.DOFade(0, 2f).From(1).onStepComplete = () =>
        {
            canvasGroup.gameObject.SetActive(false);
            console.SetActive(true);
            console.transform.DOScale(1, 1f).From(0);
        };
        Debug.Log("canvasGroup.alpha: " + canvasGroup.alpha);

    }
}
