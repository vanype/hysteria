using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float speed;
    public float jumpForce;
    private bool _isGround = true;
    public Sprite hyesteriasprite;
    bool Hysteria = false;
    public GameObject particle;
    public string nextLevel;
    public string thisLevel;


    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        if(Input.GetAxis("Horizontal")  != 0 )
        {
            _rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, _rb.velocity.y);
            
        }
        if (Input.GetAxis("Jump") > 0 && _isGround)
        {
            _rb.AddForce(new Vector2(0, jumpForce));
            _isGround = false;
        }
    }

    private void OnCollisioStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            _isGround = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            _isGround = true;
        }
        if (other.gameObject.tag == "trap")
        {
            SceneManager.LoadScene(thisLevel);
        }
        if (other.gameObject.tag == "door")
        {
            if (Hysteria)
            {
                
                GameObject gm = Instantiate(particle);
                gm.transform.position = other.gameObject.transform.position;
                Destroy(other.gameObject);

            }
        }
        if(other.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(nextLevel);
        }
    }

    
    
    

    public void SpriteShift()
    {
        GetComponent<SpriteRenderer>().sprite = hyesteriasprite;
        Hysteria = true;
    }
}
