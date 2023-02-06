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
        variableStorage.TryGetValue("$isCode", out isCode);
        if (!isCode)
        {
            
        }
    }
    void IE WaitToStartChat(float time){

    }

    public void StartChat(string nodeName)
    {
        dialogueRunner.StartDialogue(nodeName);
    }
}
