using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed=8f;
    private Rigidbody bulletRigid;
    // Start is called before the first frame update
    void Start()
    {
        bulletRigid=GetComponent<Rigidbody>();
        bulletRigid.velocity=transform.forward*speed;
        Destroy(gameObject,3f);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player"){
            playercontroller playercon=other.GetComponent<playercontroller>();

            if (playercon!=null){
                playercon.Die();
            }
        }
    }
}
