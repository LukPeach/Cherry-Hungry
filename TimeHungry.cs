using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Script time game
//The time runs out to end the game.
public class TimeHungry : MonoBehaviour
{
    private void Update()
    {
        GetComponent<Slider>().value = Gamemanager.Instance.time - Time.timeSinceLevelLoad / Gamemanager.Instance.timeOut;

        if (GetComponent<Slider>().value <= 0)
        {
            SceneManager.LoadScene("Dead");
        }  
    }

}
