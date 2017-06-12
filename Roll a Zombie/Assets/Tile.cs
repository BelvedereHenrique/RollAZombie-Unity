using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

	public GameManager GameManager;
	public AudioClip Beep;
	AudioSource Source;
	// Use this for initialization
	void Start () {
		Source = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		GameManager.AddPoint();
		Source.PlayOneShot(Beep);
	}
}
