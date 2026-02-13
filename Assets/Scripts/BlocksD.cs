using UnityEngine;

public class BlocksD : MonoBehaviour
{
   
    public Vector2 speedMinMax;
    public float speed;
    public float bottomHeight;
    
    void Start()
    {
        speedMinMax.x = 4;
        speedMinMax.y = 13;
        speed = Mathf.Lerp(speedMinMax.x,speedMinMax.y, Difficulty.getDifficultyPercentage());
        bottomHeight = - Camera.main.orthographicSize - transform.localScale.y;
    }
   
    void Update()
    {
     transform.Translate(Vector3.down * Time.deltaTime * speed);    
     if(transform.position.y < bottomHeight)
        {
            Destroy(gameObject);
        }
    }
}
