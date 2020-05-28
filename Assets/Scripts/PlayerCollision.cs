using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    GameManager instance;
    Rigidbody2D myRigidBody;

    public float bounceForce;

    // Start is called before the first frame update
    void Start()
    {
        instance = FindObjectOfType<GameManager>();
        myRigidBody = GetComponent<Rigidbody2D>();

        if (bounceForce <= 0)
        {
            bounceForce = 20.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemySquish")
        {
            collision.gameObject.GetComponentInParent<Enemy_Walker>().IsSquished();

            myRigidBody.velocity = Vector2.zero;
            myRigidBody.AddForce(Vector2.up * bounceForce);
        }
    }
}
