using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script gamemanager.
public class Gamemanager : Singgleto<Gamemanager>
{
    public float timeOut;
    public float time;
    public float sPeedHumburger;
    public float sPeedCherry;

    public int Score;
    public int numRespawnbg;
    public int numRespawnch;
    public int Cherry;

    private void Awake()
    {
        Cherry = 0;
        Score = 0;
    }

}
