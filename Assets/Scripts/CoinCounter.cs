using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;    

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;

    public TMP_Text coinText;
    public int currentCoins = 0;

    void Awake(){
        instance = this;
    }

    void Start()
    {
        coinText.text = "COINS: " + currentCoins.ToString();
    }

public void IncreaseCoins(int x){
    currentCoins += x;
    coinText.text = "COINS: " + currentCoins.ToString();

}
}
