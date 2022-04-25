using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public static soundManager instance;
    public AudioSource coinssource;
    public AudioClip coinSound;
    public AudioClip deathSound;

    private void Awake() {
    	GameObject[] musicObj = GameObject.FindGameObjectsWithTag("SoundManager");
        if( musicObj.Length > 1) {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
     }
}
