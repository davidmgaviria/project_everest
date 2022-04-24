using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    
    private GameObject mainCamera;

    private void Start () {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    private void OnCollisionEnter2D(Collision2D collision)  {
        if (collision.gameObject.CompareTag("Death") || collision.gameObject.CompareTag("Boulder")) {
            soundManager.instance.coinssource.PlayOneShot(soundManager.instance.deathSound);
            Die();
        }
    }

    private void Die() {
        //update player stats & coin display
        PlayerStats.deathCount++;
        PlayerStats.gameScore += PlayerStats.deathScorePenalty;
        gameObject.GetComponent<CoinCollector>().updateScoreDisplay();

        //change player & camera position
        transform.position = PlayerStats.spawnPoint;
        mainCamera.GetComponent<CameraFollow>().cameraToPlayer();
    }
}
