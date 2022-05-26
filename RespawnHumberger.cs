using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script randomly spawned a humberger.
public class RespawnHumberger : MonoBehaviour
{
     public GameObject HumBurGer;
     public GameObject[] posGame;
     int ranDom = 0;

    private void Start()
    {
        //A random spawn point starts the game.
        ranDom = Random.Range(0, 4);
        GameObject insHumBurGer = Instantiate(HumBurGer, posGame[ranDom].transform.position, posGame[ranDom].transform.rotation) as GameObject;
        Rigidbody insBulletRigibody = insHumBurGer.GetComponent<Rigidbody>();
        ranDom = Random.Range(5, 9);
        GameObject insHumBurGer1 = Instantiate(HumBurGer, posGame[ranDom].transform.position, posGame[ranDom].transform.rotation) as GameObject;
        Rigidbody insBulletRigibody1 = insHumBurGer1.GetComponent<Rigidbody>();
        ranDom = Random.Range(10, 14);
        GameObject insHumBurGer2 = Instantiate(HumBurGer, posGame[ranDom].transform.position, posGame[ranDom].transform.rotation) as GameObject;
        Rigidbody insBulletRigibody2 = insHumBurGer2.GetComponent<Rigidbody>();
        ranDom = Random.Range(15, 19);
        GameObject insHumBurGer3 = Instantiate(HumBurGer, posGame[ranDom].transform.position, posGame[ranDom].transform.rotation) as GameObject;
        Rigidbody insBulletRigibody3 = insHumBurGer3.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        RandomRespawn();
    }
    void RandomRespawn()
    {
        //random spawn point in game.
        if (Gamemanager.Instance.numRespawnbg >= 1)
        {
            ranDom = Random.Range(0, 19);
                GameObject insHumBurGer = Instantiate(HumBurGer, posGame[ranDom].transform.position, posGame[ranDom].transform.rotation) as GameObject;
                Rigidbody insBulletRigibody = insHumBurGer.GetComponent<Rigidbody>();
            Gamemanager.Instance.numRespawnbg = 0;
        }
    }
}
