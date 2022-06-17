using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PU_SpeedUpController : MonoBehaviour
{
    public PowerUpManager manager;
    //public Collider2D ball;
    //public float magnitude;
    //public Rigidbody2D rig;

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
            ball.GetComponent<BallControl>().ActivatePUSpeedUp(magnitude);

            StartCoroutine(ResetPower());
        }
    }

    private IEnumerator ResetPower()
    {
        yield return new WaitForSeconds(2f);
        ball.GetComponent<BallControl>().DeactivatePUSpeedUp(magnitude);
        manager.RemovePowerUp(gameObject);
    }
    */

}
