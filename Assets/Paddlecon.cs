using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddlecon : MonoBehaviour {

    private float RotateSpeed = 5f;
    private float Radius = 10f;

    private Vector2 _centre;
    private float _angle;

    private void Start()
    {
        _centre = new Vector2(0,0);
    }

    private void FixedUpdate()
    {
       if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            _angle -= RotateSpeed * Time.deltaTime;

            var offset = new Vector2(Mathf.Cos(_angle), Mathf.Sin(_angle)) * Radius;
            transform.position = _centre + offset;
        }
       else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _angle += RotateSpeed * Time.deltaTime;

            var offset = new Vector2(Mathf.Cos(_angle) , Mathf.Sin(_angle)) * Radius;
            transform.position = _centre + offset;
        }        
    }


}
