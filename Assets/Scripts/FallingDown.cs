using UnityEngine;

public class FallingDown : MonoBehaviour
{
    public GameObject fallingObj;
    public Vector2 spawnTimeMinMax;
    float nextSpawnTime;
    public Vector2 spawnSizeMinMax;
    
    public float spawnAngleMax;
    
    Vector2 boundary;

    void Start()
    {
        boundary = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
        spawnSizeMinMax.x = 0.6f;
        spawnSizeMinMax.y = 2.3f;
        spawnAngleMax = 10f;
        spawnTimeMinMax.x = 1f;
        spawnTimeMinMax.y = 0.3f;

    }


    void Update()
    {
        if (Time.timeScale == 0f) return;
        if (Time.timeSinceLevelLoad > nextSpawnTime){
        float secondsBetweenSpawn = Mathf.Lerp(spawnTimeMinMax.x, spawnTimeMinMax.y, Difficulty.getDifficultyPercentage());
        float spawnAngle = Random.Range(-spawnAngleMax, spawnAngleMax);
        nextSpawnTime = Time.timeSinceLevelLoad + secondsBetweenSpawn;        
        float spawnSize = Random.Range(spawnSizeMinMax.x, spawnSizeMinMax.y);
        Vector2 randomSpawn = new Vector2(Random.Range(-boundary.x,boundary.x), boundary.y+spawnSize);
        GameObject newBlock = (GameObject)Instantiate(fallingObj, randomSpawn, Quaternion.Euler(Vector3.forward * spawnAngle));
        newBlock.transform.localScale = Vector2.one * spawnSize;
        }
        
    }
   
}
