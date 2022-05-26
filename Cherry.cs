using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The script is inside the cherry.
public class Cherry : MonoBehaviour
{
    SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        //spin cherry.
        transform.Rotate(new Vector3(0, Gamemanager.Instance.sPeedCherry, 0));
    }
    private void OnTriggerEnter(Collider other)
    {
        //Cherry check collided with the player.
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            Gamemanager.Instance.Cherry += 1;
            Gamemanager.Instance.Score += 5;
            Gamemanager.Instance.numRespawnch++;
            Gamemanager.Instance.time = Gamemanager.Instance.time + 1f;
        }
        if (other.tag == "Item")
        {
            Destroy(gameObject);
            Gamemanager.Instance.numRespawnch++;
        }
    }
}
