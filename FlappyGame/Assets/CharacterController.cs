using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 jumpForce = new Vector2(0, 300);

	// Use this for initialization
	void Start ()
    {
        // Grab the rigidbody reference.
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetKeyDown(KeyCode.Space))
        {
            // Reset all velocity so there is no force going down
            rb.velocity = Vector2.zero;
            // add jump force
            rb.AddForce(jumpForce);
        }
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        Die();
    }

    void Die()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
