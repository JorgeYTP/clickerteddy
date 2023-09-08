using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Game : MonoBehaviour
{
    public Text scoreText; 
    public float currentScore;
    public float hitPower;
    public float scoreIncreasedPersecond ;
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
        currentScore = 0;
        hitPower = 1; 
        scoreIncreasedPersecond= 1;
        x = 0f; 
         
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (int)currentScore + "$";
        scoreIncreasedPersecond = x * Time.deltaTime;
        currentScore = currentScore + scoreIncreasedPersecond;


        shop1text.text = "Tier 1:" + shop1prize + "$";
        shop2text.text = "Tier 2:" + shop2prize + "$";

        amount1text.text  = "Tier 1:" + amount1 + "arts $: " + amount1Profit + "/s";
        amount2text.text = "Tier 2: " + amount2 + "arts $:" + amount2Profit + "/s";

        shop3text.text = "Tier 3:" + shop3prize + "$";
        shop4text.text = "Tier 4:" + shop4prize + "$";

        amount3text.text = "Tier 3:" + amount3 + "arts $: " + amount3Profit + "/s";
        amount4text.text = "Tier 4: " + amount4 + "arts $:" + amount4Profit + "/s";
    }
    public void Hit()
    {
        currentScore += hitPower; 
    }

    public void shop1()
    {
        if(currentScore>=shop1prize)
        {
            currentScore -= shop1prize;
            amount1 +=1;
            amount1Profit +=1;
            x += 1;
            shop1prize += 50; 
        }
    }

    public void shop2()
    {
        if (currentScore >= shop2prize)
        {
            currentScore -= shop2prize;
            amount2 += 3;
            amount2Profit += 3;
            x += 3;
            shop2prize += 150 ;
        }
    }

    public void shop3()
    {
        if (currentScore >= shop3prize)
        {
            currentScore -= shop3prize;
            amount3 += 5;
            amount3Profit += 5;
            x += 5;
            shop3prize += 600;
        }
    }

    public void shop4()
    {
        if (currentScore >= shop4prize)
        {
            currentScore -= shop4prize;
            amount4 += 7;
            amount4Profit += 7;
            x += 7;
            shop4prize += 2000;
        }
    }
}
