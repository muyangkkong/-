using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gamemanager : MonoBehaviour
{
    public GameObject gameovertext;
    public Text timeText;
    public Text recordtext;

    private float surviveTime;
    private bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        surviveTime=0;
        isGameOver=false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver){
            surviveTime+=Time.deltaTime;
            timeText.text="Time:"+(int)surviveTime;
        }
        else{
            if (Input.GetKeyDown(KeyCode.R)){
                SceneManager.LoadScene("총알게임");
            }
        }
    }
    public void Endgame(){
        isGameOver=true;
        gameovertext.SetActive(true);

        float bestTime=PlayerPrefs.GetFloat("bestTime");

        if (surviveTime>bestTime){
            bestTime=surviveTime;
            PlayerPrefs.SetFloat("bestTime",bestTime);
        }
        recordtext.text="BestTime"+(int)bestTime;
    }
}
