using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingBounce : MonoBehaviour
{
    public float BounceForce;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Strikers")
        {
            if (Input.touchCount!=1)
            {
                Touch _touch = Input.GetTouch(0);
                Vector2 _touchPosition = _touch.position;

                if (_touch.phase == TouchPhase.Ended)
                    collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * BounceForce,ForceMode2D.Impulse);
            }
        }
    }
}
