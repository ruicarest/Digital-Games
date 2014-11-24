#pragma strict

 
 var moveSpeed = 3; 
 
 var rotationSpeed = 3; 
 
 var range_move : float=10f;
 var range_look : float=10f;
 var range_stop : float=0;
 var quartenion : Vector4;
 
 private var Init_position : Vector3;
 private var Init_rotation : Vector3;
 private var myTransform : Transform; 
 private var target : Transform; //cant't be bothered to do any commments
 private var first : int = 1;
 
 function Awake()
 {
     myTransform = transform; 
     Init_position = myTransform.position;

 }
  
 function Start()
 {
      target = GameObject.FindWithTag("Player").transform; 
  	  
 }
  
 function Update () {
    
     var distance = Vector3.Distance(myTransform.position, target.position);
     var Init_distance = Vector3.Distance(myTransform.position, Init_position);
     

     //rotate to look at the player
     if (distance<=range_look &&  distance>=range_move){
     first=0;
     print("Init_distance_Stare");

     myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
     Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
     }
  	//move towards the player
     else if(distance<=range_move && distance>range_stop){
     print("Init_distance_Move");

     myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
     Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
	 //animation.Play("walk01");
     myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
     }
     //Stop at the player position
     else if (distance<=range_stop) {
     print("Init_distance_Stop");

	 //animation.Play("attack01");
     myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
     Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
     }
     //Return to init_position
     else if (distance>=range_look && Init_distance>= 1 ){
     	if(first == 0 ){
     	myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
     Quaternion.LookRotation(Init_position - myTransform.position), 1000*Time.deltaTime);
     //animation.Play("walk01");
     	}
     	
     first=1;
     myTransform.rotation.x = 0;
     myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
     } 

  
 }