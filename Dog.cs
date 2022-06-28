using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public GameObject particle;
    public Transform pos;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "trap")
        {
            GameObject gm = Instantiate(particle);
            gm.transform.position = gameObject.transform.position;
            Camera.main.gameObject.GetComponent<Hysteria>().HysteriaUpdate(1);
            Destroy(gameObject);
            
        }
    }
}
