using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class GameController : MonoBehaviour
{
    //味方陣営の番号
    public int ally1Number;
    public int ally2Number;
    //敵陣営の番号
    public int enemy1Number;
    public int enemy2Number;
    //味方陣営の番号のui
    public GameObject ally1;
    public GameObject ally2;
    //敵陣営の番号のui
    public GameObject enemy1;
    public GameObject enemy2;
    //味方陣営の番号の合計
    public GameObject allypower;
    //敵陣営の番号の合計
    public GameObject enemypower;
    //数字が悪い時入れ替えるui
    public GameObject exchange;
    //番号が決まったら勝負するui
    public GameObject batoru;

    void Start()
    {
        //味方陣営の番号をランダムにする
        ally1Number = Random.Range(1, 13);
        ally2Number = Random.Range(1, 13);
        //敵陣営の番号をランダムにする
        enemy1Number = Random.Range(1, 13);
        enemy2Number = Random.Range(1, 13);


        {
            //getNnmberは番号と同じ意味を持つ
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

    private int jugu()
    {
        ally1Number = Random.Range(1, 13)+ally2Number;
        enemy1Number = Random.Range(1, 13) + enemy1Number; 
        allypower.transform.Find("Text").GetComponent<Text>().text = .ToString();
        enemypower.transform.Find("Text").GetComponent<Text>().text = "?";
        return 0;
    }

}

