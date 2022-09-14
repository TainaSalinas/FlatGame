using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    bool relativeMovement;
    public float movementSpeed = 10;

    public KeyCode upKey = KeyCode.W;
    public KeyCode leftKey = KeyCode.A;
    public KeyCode downKey = KeyCode.S;
    public KeyCode rightKey = KeyCode.D;
    

    private void Update()
    {
        UpdateMovement();
    }

    private void UpdateMovement()
    {
        var direction = Vector3.zero;

        if (Input.GetKey(leftKey))
        {
            direction -= new Vector3(1, 0, 0);
        }

        if (Input.GetKey(rightKey))
        {
            direction += new Vector3(1, 0, 0);
        }

        if (Input.GetKey(upKey))
        {
            direction += new Vector3(0, 1, 0);
        }

        if (Input.GetKey(downKey))
        {
            direction -= new Vector3(0, 1, 0);
        }

        Vector2 displacement = direction * movementSpeed * Time.deltaTime*7;

        if (relativeMovement)
        {
            transform.Translate(displacement, Space.Self);
        }
        else
        {
            transform.Translate(displacement, Space.World);
        }
    }

}