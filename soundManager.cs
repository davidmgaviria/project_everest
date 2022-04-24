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
    	instance = this;
    }
    void Start()
    {

    }
    
    void Update()
    {

    }
}
