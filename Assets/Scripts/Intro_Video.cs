using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class Intro_Video : MonoBehaviour {

    public int nextLevel;
    public MovieTexture movie;
    // Use this for initialization
    void Start ()
    {
        ((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
    }
	
    public void OrMouseDown()
    {
        ((MovieTexture)GetComponent<Renderer>().material.mainTexture).Stop();
        Application.LoadLevel(nextLevel);
    }

	// Update is called once per frame
	void Update () {
		if (!((MovieTexture)GetComponent<Renderer>().material.mainTexture).isPlaying)
        {
            Application.LoadLevel(nextLevel);
        }
	}
}
