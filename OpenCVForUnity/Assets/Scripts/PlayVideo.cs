using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayVideo : MonoBehaviour {

	public MovieTexture movie;

	// Use this for initialization
	void Start () {
		movie.loop = true;
		GetComponent<RawImage> ().texture = movie as MovieTexture;
		movie.Play ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
