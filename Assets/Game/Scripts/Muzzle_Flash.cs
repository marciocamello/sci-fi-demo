using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muzzle_Flash : MonoBehaviour {

    [SerializeField]
    private ParticleSystem _muzzleFlash;

	// Use this for initialization
	private void Start ()
    {
        _muzzleFlash = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	private void Update ()
    {
	    if (Input.GetMouseButtonDown(0))
        {
            //_muzzleFlash.Play();
        }

        if (Input.GetMouseButtonUp(0))
        {
            //_muzzleFlash.Stop();
        }
	}
}
