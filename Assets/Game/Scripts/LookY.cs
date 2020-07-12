using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookY : MonoBehaviour
{
    [SerializeField]
    private float _sensivity = 1f;

    [SerializeField]
    private bool _mouseInvert = true;

	// Use this for initialization
	private void Start ()
    {
		
	}
	
	// Update is called once per frame
	private void Update ()
    {
        float _mouseY = Input.GetAxis("Mouse Y");

        Vector3 newRotation = transform.localEulerAngles;

        if(_mouseInvert == true)
        {
            newRotation.x -= _mouseY * _sensivity;
        }
        else
        {
            newRotation.x += _mouseY * _sensivity;
        }

        transform.localEulerAngles = newRotation;
	}
}
