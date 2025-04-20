using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{

    public string name;
    [TextArea(3, 10)]
    public string[] sentences;
    public Sprite npcImage;
    public DialogueLine[] lines;

}
[System.Serializable]
public class DialogueLine
{
    public string speakerName;
    public string sentence;
    public Sprite npcImage;
}
