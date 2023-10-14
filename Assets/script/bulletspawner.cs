using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletspawner : MonoBehaviour
{
    public GameObject bulletprefeb;
    public float spawnRatemin=0.5f;
    public float spawnRateMax=3f;

    private Transform target;
    private float spawnRate;
    private float timeAfterSpawn;//최근 생성시점에서 지난 시간
    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawn=0f;
        spawnRate=Random.Range(spawnRatemin,spawnRateMax);
        target=FindObjectOfType<playercontroller>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn+=Time.deltaTime;
        if (timeAfterSpawn>=spawnRate){
            timeAfterSpawn=0f;
        

        GameObject bullet=Instantiate(bulletprefeb,transform.position,transform.rotation);
        bullet.transform.LookAt(target);
        spawnRate=Random.Range(spawnRatemin,spawnRateMax);}
    }
}
