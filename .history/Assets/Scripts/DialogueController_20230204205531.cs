using System.Dynamic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using DG.Tweening;

public class DialogueController : MonoBehaviour
{
    public static NPCSingleton Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }

        Instance = this;
    }
    [SerializeField] DialogueRunner runner;
    public RectTransform consoleView;


    void Awake()
    {
        runner.AddCommandHandler<string>("LoadScene", LoadScene);

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
    public void StartChat(string nodeName)
    {
        consoleView.gameObject.SetActive(true);
        consoleView.localScale = Vector3.zero;
        consoleView.DOScale(1, 1f).From(0).onStepComplete
                = () => { runner.StartDialogue(nodeName); };
        runner.StartDialogue(nodeName);
    }
}
