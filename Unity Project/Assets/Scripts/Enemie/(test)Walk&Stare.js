#pragma strict

 
 var moveSpeed = 3; 
 
 var rotationSpeed = 3; 
 
 var range_move : float=10f;
 var range_look : float=10f;
 var range_stop : float=0;
 
 private var myTransform : Transform; 
 private var Init_position : Transform;
 private var target : Transform; //cant't be bothered to do any commments
 
 function Awake()
 {
     myTransform = transform; 
    
     Init_position = transform;
 }
  
 function Start()
 {
      target = GameObject.FindWithTag("Player").transform; 
  
 }
  
 function Update () {
     //rotate to look at the player
     var distance = Vector3.Distance(myTransform.position, target.position);
     if (distance<=range_look &&  distance>=range_move){
     myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
     Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
     }
  
  	//move towards the player
     else if(distance<=range_move && distance>range_stop){
     myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
     Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
	 //animation.Play("walk01");
     myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
     }
     //Stop at the player position
     else if (distance<=range_stop) {
	 //animation.Play("attack01");
     myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
     Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
     }
     else {
     myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
     Quaternion.LookRotation(Init_position.position - myTransform.position), rotationSpeed*Time.deltaTime);
     //animation.Play("walk01");
     myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
     } 

  
 }