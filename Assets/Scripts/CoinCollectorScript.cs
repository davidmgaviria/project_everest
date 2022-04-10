using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CoinCollectorScript : MonoBehaviour
{
    // Start is called before the first frame update
    //private float coin = 0;
    
//public TextMeshProUGUI textcoins;

public float TotalCoins =0f;
public TextMeshProUGUI txt;

  
  



    private void OnTriggerEnter2D(Collider2D other){

    	if (other.transform.tag == "coin"){
            //coin ++;
            //textcoins.text = coin.ToString();
            TotalCoins += 1;
            txt.text = "Total Coins: " + TotalCoins.ToString();
            Destroy(other.gameObject);
          
          
    	Debug.Log("hey, You got a coin");

    }
    }
}
