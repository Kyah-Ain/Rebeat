using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    [Header("Reference")]
    public Text textComponent;

    [Header("Dialogue")]
    public string[] lines;
    public float textSpeed;

    [Header("Regulator")]
    public int indexCounter;
    public float timeBeforeNextDialogue = 5f;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartCoroutine(DialogueIteration());
    }

    IEnumerator DialogueIteration()
    {
        for (int i = 0; i < lines.Length; i++)
        {
            StartCoroutine(TextIterator());
            yield return new WaitForSeconds(timeBeforeNextDialogue);
            textComponent.text = string.Empty;
        }
    }

    IEnumerator TextIterator()
    {
        foreach (char c in lines[indexCounter].ToCharArray())
        {
            textComponent.text += c;
            
            yield return new WaitForSeconds(textSpeed);
        }
        indexCounter++;
    }
}
