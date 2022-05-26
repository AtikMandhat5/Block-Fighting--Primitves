using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public GameObject[] enemies; 
	public GameObject powerUp;

	private float zEnemySpawn=12.0f;
	private float xSpawnRange=16.0f;
	private float zPowerupRange=5.0f;
	private float ySpawn=0.70f;
	
	// time
	private float enemySpawnTime=1.0f;//enemy spawn-time
	private float powerUpSpawnTime=5.0f;//powerup spwan-time

	private float startDelay=2.0f;//delay time



    // Start is called before the first frame update
    void Start()
    {
    	InvokeRepeating("SpawnRandomEnemy",startDelay,enemySpawnTime);
    	InvokeRepeating("SpawnRandomPowerup",startDelay,powerUpSpawnTime);
    		    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnRandomEnemy()
    {
    	int randomIndex=Random.Range(0,enemies.Length);  //radnom index 
    	float randomX=Random.Range(-xSpawnRange,xSpawnRange); //random x value 
    		
    	Vector3 spawnPos= new Vector3(randomX,ySpawn,zEnemySpawn); //postion 

    	//enimies, position, object transfrom
    	Instantiate(enemies[randomIndex],spawnPos,enemies[randomIndex].gameObject.transform.rotation);
    }

    public void SpawnRandomPowerup()
    {

    	float randomX=Random.Range(-xSpawnRange,xSpawnRange); //random X value 
    	float randomZ=Random.Range(-zPowerupRange,zPowerupRange); //random Z value 
    		
    	Vector3 spawnPos= new Vector3(randomX,ySpawn,randomZ); //postion 

    	//powerup , position, object transfrom
    	Instantiate(powerUp,spawnPos,powerUp.gameObject.transform.rotation);

    }
}
