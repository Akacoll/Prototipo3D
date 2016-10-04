using UnityEngine;
using System.Collections;

public class somTecla : MonoBehaviour {

	//public GameObject objeto;
	//public AudioClip som;
	private AudioSource audioSource;

	void Awake()
	{
		audioSource = GetComponent<AudioSource> ();
	}

	void OnCollisionEnter()
	{
		audioSource.Play ();	
	}

	void OnClick()
	{
		audioSource.Play ();
	}
}
