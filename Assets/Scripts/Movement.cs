using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public float speed = 13f;
    float screenBoundary;
    public event System.Action playerDeath;
     
    
    void Start()
    {
        float playerHalfWidth = transform.localScale.x /2;
        screenBoundary = Camera.main.aspect * Camera.main.orthographicSize + playerHalfWidth;
        
        
    }
    void Update()
    {

        Vector2 move = Keyboard.current != null
            ? new Vector2(
                ((Keyboard.current.aKey.isPressed|| Keyboard.current.leftArrowKey.isPressed )? -1 : 0) + ((Keyboard.current.dKey.isPressed||Keyboard.current.rightArrowKey.isPressed )? 1 : 0),0
                
              )
            : Vector2.zero;
        
        Vector3 input = new Vector3(move.x, 0f, move.y);
        Vector3 direction = input.normalized;
        Vector3 velocity = direction * speed;
        Vector3 moveAmount = velocity * Time.deltaTime;
        
        transform.Translate(moveAmount);

        if(transform.position.x < -screenBoundary)
        {
            transform.position = new Vector2(screenBoundary,transform.position.y);
        }
        if(transform.position.x > screenBoundary)
        {
            transform.position = new Vector2(-screenBoundary,transform.position.y);
        }
    }
    void OnTriggerEnter2D(Collider2D tc)
    {
        if(tc.tag == "Block")
        {
            Destroy(gameObject);  
            if(playerDeath!=null)
            {
                playerDeath();
            }
        }
    }
    }

