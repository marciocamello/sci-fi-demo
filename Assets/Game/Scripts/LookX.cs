using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookX : MonoBehaviour
{
    [SerializeField]
    private float _sensivity = 1f;

	// Use this for initialization
	private void Start ()
    {
		
	}

    // Update is called once per frame
    private void Update ()
    {
        float _mouseX = Input.GetAxis("Mouse X");

        Vector3 newRotation = transform.localEulerAngles;
        newRotation.y += _mouseX * _sensivity;
        transform.localEulerAngles = newRotation;
    }
}
