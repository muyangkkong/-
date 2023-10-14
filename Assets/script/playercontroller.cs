using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    private Rigidbody playerRigid;
    public float speed =8f;//이동 속력
    // Start is called before the first frame update
    
    void Start(){
        playerRigid=GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        float xInput=Input.GetAxis("Horizontal");//어떤축에 대한 입력값을 숫자로 반환하는 메서드임
        float zInput=Input.GetAxis("Vertical");

        float xSpeed= xInput*speed;
        float zSpeed= zInput*speed;

        Vector3 newVelocity=new Vector3(xSpeed,0f,zSpeed);
        playerRigid.velocity=newVelocity;
    }
    public void Die(){
        gameObject.SetActive(false);
        gamemanager gameManager = FindObjectOfType<gamemanager>();
        gameManager.Endgame();

    }
}
