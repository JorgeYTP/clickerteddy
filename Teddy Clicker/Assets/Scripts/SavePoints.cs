using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable] 
public class SavePoints : MonoBehaviour
{
    public Text scoreText;
    public float currentScore;
    public float hitPower;
    public float scoreIncreasedPersecond;
    public float x;




    public int shop1prize;
    public Text shop1text;

    public int shop2prize;
    public Text shop2text;


    public Text amount1text;
    public int amount1;
    public float amount1Profit;

    public Text amount2text;
    public int amount2;
    public float amount2Profit;

    public int shop3prize;
    public Text shop3text;

    public int shop4prize;
    public Text shop4text;


    public Text amount3text;
    public int amount3;
    public float amount3Profit;

    public Text amount4text;
    public int amount4;
    public float amount4Profit; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public SavePoints (float currentScore,float hitPower, float scoreIncreasedPersecond , float x  , int shop1prize, int shop2prize, int shop3prize, int shop4prize, int amount1Profit, int amount2Profit, int amount3Profit, int amount4Porfit)
    {

    }
        
        
        
}
