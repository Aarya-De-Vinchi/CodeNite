using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public Image npcImageUI;
    public Button takeQuizButton; // Reference to the Take Quiz button

    private Queue<DialogueLine> lines;

    void Start()
    {
        lines = new Queue<DialogueLine>();
        if (takeQuizButton != null)
            takeQuizButton.gameObject.SetActive(false); // Hide at start
    }

    public void StartDialogue(Dialogue dialogue)
    {
        lines.Clear();

        foreach (DialogueLine line in dialogue.lines)
        {
            lines.Enqueue(line);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (lines.Count == 0)
        {
            EndDialogue();
            return;
        }

        DialogueLine currentLine = lines.Dequeue();
        nameText.text = currentLine.speakerName;
        dialogueText.text = currentLine.sentence;
        npcImageUI.sprite = currentLine.npcImage;
    }

    void EndDialogue()
    {
        Debug.Log("End of conversation");
        npcImageUI.sprite = null;
        if (takeQuizButton != null)
            takeQuizButton.gameObject.SetActive(true); // Show Take Quiz button
    }
}
