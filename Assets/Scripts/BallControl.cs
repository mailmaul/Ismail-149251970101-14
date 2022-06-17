using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;
    public float magnitude;
    public Collider2D paddle;
    public Collider2D paddle2;

    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed ;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "PU-SpeedBall")
        {
            Destroy(collision.gameObject);
            ActivatePUSpeedUp();

            StartCoroutine(ResetPower());
        }
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

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x , resetPosition.y, 2);
    }

    public void ActivatePUSpeedUp()
    {
        rig.velocity *= magnitude;
        GetComponent<SpriteRenderer>().color = Color.white;
        Debug.Log("Ball Speed Bertampah");
    }

    public void DeactivatePUSpeedUp()
    {
        rig.velocity /= magnitude;
        GetComponent<SpriteRenderer>().color = Color.cyan;
        Debug.Log("Ball Speed Normal");
    }

    public void ActivatePaddleSpeedUp()
    {
        paddle.GetComponent<Paddle>().speed = paddle.GetComponent<Paddle>().speed * 2;
        paddle2.GetComponent<Paddle>().speed = paddle.GetComponent<Paddle>().speed * 2;
        paddle.GetComponent<SpriteRenderer>().color = Color.red;
        Debug.Log("Paddle Speed Bertambah");
    }

        public void DeactivatePaddleSpeedUp()
    {
        paddle.GetComponent<Paddle>().speed = paddle.GetComponent<Paddle>().speed / 2;
        paddle2.GetComponent<Paddle>().speed = paddle.GetComponent<Paddle>().speed / 2;
        paddle.GetComponent<SpriteRenderer>().color = Color.white;
        Debug.Log("Paddle Speed Normal");
    }

    public void ActivatePaddleLong()
    {
        Vector3 objectScale = transform.localScale;
        paddle.GetComponent<Transform>().transform.localScale = new Vector3(1,  2 * magnitude, 1);
        paddle.GetComponent<SpriteRenderer>().color = Color.green;

        paddle2.GetComponent<Transform>().transform.localScale = new Vector3(1,  2 * magnitude, 1);
        paddle2.GetComponent<SpriteRenderer>().color = Color.green;
    }

    public void DeactivatePaddleLong()
    {
        Vector3 objectScale = transform.localScale;
        paddle.GetComponent<Transform>().transform.localScale = new Vector3(1,  objectScale.y / magnitude, 1);
        paddle.GetComponent<SpriteRenderer>().color = Color.white;

        paddle2.GetComponent<Transform>().transform.localScale = new Vector3(1,  objectScale.y / magnitude, 1);
        paddle2.GetComponent<SpriteRenderer>().color = Color.white;
    }

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

    private IEnumerator ResetPower()
    {
        yield return new WaitForSeconds(2f);
        DeactivatePUSpeedUp();
    }

}
