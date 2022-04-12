using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CoinCollector : MonoBehaviour
{
    
    public TextMeshProUGUI scoreText;

    //when level loads we want score to show the current value
    private void Start() {
        updateScoreDisplay();
    }

    //update value when coin is collected
    private void OnTriggerEnter2D(Collider2D other){
    	if (other.transform.tag == "coin") {
            PlayerStats.gameScore += 1;
            updateScoreDisplay();
            Destroy(other.gameObject);
        }
    }

    public void updateScoreDisplay() {
        scoreText.text = "Score: " + PlayerStats.gameScore.ToString();
    }
}
