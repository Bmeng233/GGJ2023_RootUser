using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class SceneTransition : MonoBehaviour
{
    public CanvasGroup canvasGroup;

    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        Debug.Log("canvasGroup.alpha: " + canvasGroup.alpha);
        canvasGroup.DOFade(0, 2f).From(1).onStepComplete = () =>
        {
            canvasGroup.gameObject.SetActive(false);
            
        };
        Debug.Log("canvasGroup.alpha: " + canvasGroup.alpha);

    }
}
