using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public int speed;
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
     public Collider2D paddle;

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
/*
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "PU-SpeedPaddle")
        {
            Destroy(collision.gameObject);
            ActivatePaddleSpeedUp();

            StartCoroutine(ResetSpeedPaddle());  
        }

        if (collision.tag == "PU-LongPaddle")
        {
            Destroy(collision.gameObject);
            ActivatePaddleLong();

            StartCoroutine(ResetLongPaddle());  
        }
    }


    public void ActivatePaddleSpeedUp()
    {
        rig.velocity *= magnitude;
        GetComponent<SpriteRenderer>().color = Color.red;
        Debug.Log("Paddle Speed Bertambah");
    }

        public void DeactivatePaddleSpeedUp()
    {
        rig.velocity /= magnitude;
        GetComponent<SpriteRenderer>().color = Color.white;
        Debug.Log("Paddle Speed Normal");
    }
*/
    public void ActivatePaddleLong()
    {
        Vector3 objectScale = transform.localScale;
        transform.localScale = new Vector3(objectScale.x*1,  objectScale.y*2, objectScale.z*1);
        GetComponent<SpriteRenderer>().color = Color.green;
    }

    public void DeactivatePaddleLong()
    {
        Vector3 objectScale = transform.localScale;
        transform.localScale = new Vector3(objectScale.x*1,  objectScale.y/2, objectScale.z*1);
        GetComponent<SpriteRenderer>().color = Color.white;
    }
/*
    private IEnumerator ResetSpeedPaddle()
    {
        yield return new WaitForSeconds(5f);
        DeactivatePaddleSpeedUp();
    }

    private IEnumerator ResetLongPaddle()
    {
        yield return new WaitForSeconds(5f);
        DeactivatePaddleLong();
    }
    */
}
