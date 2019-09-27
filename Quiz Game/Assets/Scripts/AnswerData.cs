using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is going to hold information about answers
/// This is going to be a pure C# Class not MonoBehaviour
/// [System.Serializable] is so we can edit and display values
/// using the inspector
/// </summary>

[System.Serializable]
public class AnswerData
{
    public string answerText;   // string text of the anser
    public bool isCorrect;      // weather or not the answer is correct


}
