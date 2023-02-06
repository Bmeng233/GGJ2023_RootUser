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
        bool isBinaryCode;
        variableStorage.TryGetValue("$testVariable", out testVariable);
    }

    public void StartChat(string nodeName)
    {
        dialogueRunner.StartDialogue(nodeName);
    }
}
