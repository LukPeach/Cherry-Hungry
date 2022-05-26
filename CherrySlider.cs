using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Script Show Slide Cherry.
public class CherrySlider : MonoBehaviour
{
    private void Update()
    {
        GetComponent<Slider>().value = Gamemanager.Instance.Cherry;

        //Check the cherry value and load.
        if (GetComponent<Slider>().value >=10)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
