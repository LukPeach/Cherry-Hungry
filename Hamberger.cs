using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The script is inside the hamberger.
public class Hamberger : MonoBehaviour
{
    SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        //spin hamberger.
        transform.Rotate(new Vector3(0, Gamemanager.Instance.sPeedHumburger, 0));
    }
    private void OnTriggerEnter(Collider other)
    {
        //Hamberger check collided with the player.
        if (other.tag =="Player")
        {
            Destroy(gameObject);
            Gamemanager.Instance.time = Gamemanager.Instance.time + 1f;
            Gamemanager.Instance.Score++;
            Gamemanager.Instance.numRespawnbg++;
        }
        if(other.tag == "Item")
        {
            Destroy(gameObject);
            Gamemanager.Instance.numRespawnbg++;
        }
    }
}
