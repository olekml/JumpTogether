using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerB : MonoBehaviour
{

    public float moveSpeed;
    public float jumpHeight;
	public GameObject EndGameScreen;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask WhatIsGround;
    public Text countText;
    private bool grouned;
    private int count;

    void Start()
    {
        count = 0;

        SetCountText();
    }

    void FixedUpdate()
    {
        grouned = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, WhatIsGround);
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);

            count = count + 1;

            SetCountText();
        }
		if (other.gameObject.CompareTag ("DeathZone")) {  
			Die ();
			EndGameScreen.SetActive(true);
		}
	}

	void Die() {
		Destroy (gameObject);
	}









    void SetCountText()
    {
        countText.text = "Player B score: " + count.ToString();


    }

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.UpArrow) && grouned)
        {
            Jump();
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }



    }
    void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
    }


}
