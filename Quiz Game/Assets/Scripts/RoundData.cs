using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class RoundData
{
    public string name;                     // name of the round
    public int timeLimitInSeconds;          // how many seconds player has to complete round
    public int pointsAddedForCorrectAnswer; // if you get an answer right 
    public QuestionData[] questions;        // each round is going to hold a number of question, each question holds a number of answers
}
