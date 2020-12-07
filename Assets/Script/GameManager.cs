using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO.Ports;
using System;
public class GameManager : MonoBehaviour

{
   	SerialPort sp = new SerialPort("COM3", 9600);
    public int brickNum = 40;

    public Text Score = null;
    public GameObject GameOver = null;
    public GameObject YouWin = null;
    public GameObject WaitFor = null;
    public GameObject Bricks;
    public GameObject Movebar=null;
    public static GameManager Instance = null;

    private GameObject cloneMovebar = null;
    private int scoreNum = 0;
    // Start is called before the first frame update
    void Start()
    {
		
        if (Instance == null)
        {
            Instance = this;
        }
        else if(Instance != this)
        {
            Destroy(gameObject);
        }
        SetUp();
        sp.Open();
		sp.ReadTimeout = 1;
    }

    public void SetUp()
    {
        if(Movebar!=null)
        {
            cloneMovebar = Instantiate(Movebar, Movebar.transform.position, Quaternion.identity) as GameObject;
        }
        if (Bricks != null)
        {
            Bricks = Instantiate(Bricks, Bricks.transform.position, Quaternion.identity);
        }
    }
    
    public void ChkGameOver()
    {
        if (brickNum < 1)
        {
            if (YouWin != null)
            {
                YouWin.SetActive(true);
                WaitFor.SetActive(true);
                //Invoke("Reset", resetDelay);
            }
        }

    }

    private void Reset()
    {
        Time.timeScale = 1f;
        Application.LoadLevel(Application.loadedLevel);
    }

    public void DestroyBrick()
    {  
        brickNum--;
        AddScore();
        ChkGameOver();
        Debug.Log("hit");
		if (sp.IsOpen){
			sp.Write("1");
            Debug.Log("hit");
		}
    }

    public void GameEnd()
    {
        if (GameOver != null&&brickNum>0)
        {
            GameOver.SetActive(true);
            WaitFor.SetActive(true);
			sp.Close();
        }  
    }

    public void AddScore()
    {
        scoreNum++;
        if (Score != null)
        {
            Score.text = "Score: " + scoreNum;
        }
    }
     // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            Reset(); //엔터 키를 누르면 리셋
    }
}
