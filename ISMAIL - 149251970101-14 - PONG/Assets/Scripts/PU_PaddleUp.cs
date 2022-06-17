using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PU_PaddleUp : MonoBehaviour
{
    public PowerUpManager manager;
    //public Collider2D ball;
    //public Collider2D paddle;

    public int deletePowerUp;
    private float waktu;

    private void Start() {
        waktu = 0;
    }

    private void Update() {
        waktu += Time.deltaTime;

        if( waktu > deletePowerUp)
        {
            manager.RemovePowerUp(gameObject);
            waktu -= deletePowerUp;
        }
        
    }

    /*
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Ball")
        {
            paddle.GetComponent<Paddle>().ActivatePaddleLong();

            StartCoroutine(ResetPower());
        }
    }

    private IEnumerator ResetPower()
    {
        yield return new WaitForSeconds(5f);
        paddle.GetComponent<Paddle>().DeactivatePaddleLong();
        manager.RemovePowerUp(gameObject);
    }
    */
}
