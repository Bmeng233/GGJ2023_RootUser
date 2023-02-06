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
    public RectTransform consoleView;
    public DialogueRunner dialogueRunner;

    void Awake()
    {
        consoleView.localScale = Vector3.zero;
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.DOFade(0, 5f).From(1).onStepComplete = () =>
        {
            canvasGroup.gameObject.SetActive(false);
            DialogueController.Instance.StartChat
        };

    }
}
