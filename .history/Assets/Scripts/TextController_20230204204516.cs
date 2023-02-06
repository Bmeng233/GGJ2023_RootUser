using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class TextController : MonoBehaviour
{
    public DialogueRunner dialogueRunner;
    public InMemoryVariableStorage variableStorage;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnEnable()
    {
        bool isCode = false;
        bool visited
        variableStorage.TryGetValue("$isCode", out isCode);
        if (!isCode)
        {
            StartCoroutine(WaitToStartChat(5f, "BinaryNumbers"));
        }
        else
        {
            StartCoroutine(WaitToStartChat(5f, "Code"));
        }
    }
    IEnumerator WaitToStartChat(float time, string nodeName)
    {
        yield return new WaitForSeconds(time);
        dialogueRunner.StartDialogue(nodeName);
    }

    public void StartChat(string nodeName)
    {
        dialogueRunner.StartDialogue(nodeName);
    }
}
