using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    private Rigidbody playerRigid = default;
    public float speed = default;
    // Start is called before the first frame update
    void Start()
    {
        playerRigid = GetComponent<Rigidbody>();

        Debug.Assert(playerRigid);

        if (playerRigid == null)
        GFunc.Log("이거 로그 그대로 잘 찍힌다.");
    }
    

    // Update is called once per frame
    void Update()
    {
       

        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
            playerRigid.velocity = newVelocity;
    }       //update

    public void Die()
    {
        gameObject.SetActive(false);

        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}//class PlayerControler
