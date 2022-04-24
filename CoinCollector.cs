using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CoinCollector : MonoBehaviour
{
    
    private TextMeshProUGUI scoreText;
    private GameObject coinTextObject;
    //public static AudioClip coinSound;
    //public AudioClip coinSound;


    //when level loads we want score to show the current value
    private void Start() {
        coinTextObject = GameObject.FindGameObjectWithTag("CoinDisplay");
        scoreText = coinTextObject.GetComponent<TextMeshProUGUI>();
        updateScoreDisplay();
        //coinPickupSound = Music.Load<AudioClip>("Coin_1");
    }

    //update value when coin is collected
    private void OnTriggerEnter2D(Collider2D other){
    	if (other.transform.tag == "coin") {
            PlayerStats.gameScore += 1;
            updateScoreDisplay();
            //PlaySound(coinPickupSound);
            //audioSrc.PlaySound("Coin_1")
            //AudioManager.instance.Play("Coin_1");
            soundManager.instance.coinssource.PlayOneShot(soundManager.instance.coinSound);
            Destroy(other.gameObject);
            //AudioSource.PlayClipAtPoint(coinSound, transform.position);
        }
    }

    public void updateScoreDisplay() {
        scoreText.text = "Score: " + PlayerStats.gameScore.ToString();
    }
}
