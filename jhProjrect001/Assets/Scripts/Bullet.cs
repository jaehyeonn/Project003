using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = default;
    private Rigidbody rigid = default;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.velocity = transform.forward * speed;

        //Destroy(gameObject, 3.0f);


    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "player")
        {
            Debug.Log("ºÎµúÈû??");
            PlayerControler playerControler = other.GetComponent<PlayerControler>();

            if(playerControler != null)
            {
                playerControler.Die();
            }
        }
    }

}
