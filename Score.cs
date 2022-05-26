using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script Score.
public class Score : MonoBehaviour
{
    public Text ScoreGame;

    private void Update()
    {
        ScoreGame.text = "";
        ScoreGame.text += Gamemanager.Instance.Score;
    }
}
