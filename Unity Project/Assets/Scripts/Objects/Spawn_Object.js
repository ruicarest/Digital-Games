 #pragma strict
 var spawnTrgts : GameObject[];
 var newTarget : Transform; 
 
 function Start () { //initialize spawning points array
  spawnTrgts = GameObject.FindGameObjectsWithTag("Respawn");
 
 //   Debug.Log(spawnTrgts.Length);
 }
 
 // Starting in 0.5 seconds, a projectile will be launched every 0.3 seconds
 InvokeRepeating("LaunchProjectile", 0.5, 0.3);
 
 function LaunchProjectile () {
 
  var spawnPos = spawnTrgts[(Random.Range(0, spawnTrgts.Length))].transform.position; //randomly return position of a spawn point
  
  Instantiate(newTarget, spawnPos, Quaternion.identity);
  
 // Debug.Log(spawnPos);
 }