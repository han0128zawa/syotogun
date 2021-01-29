using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class GameController : MonoBehaviour
{
    public int ally1Number;
    public int ally2Number;
    public int enemy1Number;
    public int enemy2Number;
    public GameObject ally1;
    public GameObject ally2;
    public GameObject enemy1;
    public GameObject enemy2;

 
    public GameObject exchange;
    public GameObject batoru;

    void Start()
    {
        ally1Number = Random.Range(1, 13);
        ally2Number = Random.Range(1,13);
        enemy1Number = Random.Range(1, 13);
        enemy2Number = Random.Range(1, 13);
      

        {
            ally1Number = getNnmber();
        }

        ///<summary>
        ///数字の抽選をします
        /// </summary>
        ///<retunrns></returns>
        ///
        ally1.transform.Find("Text").GetComponent<Text>().text = ally1.ToString();
        ally2.transform.Find("Text").GetComponent<Text>().text = "?";

    }

    private int getNnmber()
    {
        System.Random rondom = new System.Random();
        return rondom.Next(1, 13);
    }








}