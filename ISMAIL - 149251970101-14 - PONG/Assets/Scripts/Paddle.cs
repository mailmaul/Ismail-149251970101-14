using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public int speed;
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;

    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        Debug.Log("Paddle Speed : " + speed);
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {
        

        if (Input.GetKey(moveUp))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(moveDown))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        rig.velocity = movement;
    }
}
