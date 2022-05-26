using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script randomly spawned a cherry.
public class RespawnCherry : MonoBehaviour
{
    public GameObject Cherry;
    public GameObject[] posGamech;
    int ranDom = 0;

    private void Start()
    {
        //A random spawn point starts the game.
        ranDom = Random.Range(0, 19);
        GameObject insHumBurGer = Instantiate(Cherry, posGamech[ranDom].transform.position, posGamech[ranDom].transform.rotation) as GameObject;
        Rigidbody insBulletRigibody = insHumBurGer.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        RandomRespawn();
    }
    void RandomRespawn()
    {
        //random spawn point in game.
        if (Gamemanager.Instance.numRespawnch >= 1)
        {
            ranDom = Random.Range(0, 19);
                GameObject insHumBurGer = Instantiate(Cherry, posGamech[ranDom].transform.position, posGamech[ranDom].transform.rotation) as GameObject;
                Rigidbody insBulletRigibody = insHumBurGer.GetComponent<Rigidbody>();
            Gamemanager.Instance.numRespawnch = 0;
        }
    }
}
