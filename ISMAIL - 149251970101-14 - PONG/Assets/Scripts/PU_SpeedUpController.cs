using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PU_SpeedUpController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public float magnitude;
    public int deleteInterval;

    private float waktu;

    private void Start() {
        waktu = 0;
    }

    private void Update() {
        waktu += Time.deltaTime;

        if( waktu > deleteInterval)
        {
            manager.RemovePowerUp(gameObject);
            waktu -= deleteInterval;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision == ball)
        {
            ball.GetComponent<BallControl>().ActivatePUSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
