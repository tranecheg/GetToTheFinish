using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class simpleJump : MonoBehaviour
{
 private Rigidbody2D rb;
    private float speed = 28.1f; //28.1f

    public LayerMask layerMask;
	 public bool check, check2, check4 = false;
	 
	 public int CamMove;
public float rot;
 
	Animator anim;
		
	public bool isGround,isGround1,isGround2,isGround3;
    Transform grounded, grounded1,grounded2,grounded3;
	
	public bool isGround_2,isGround1_2,isGround2_2,isGround3_2;
    Transform grounded_2, grounded1_2,grounded2_2,grounded3_2;
	
	public GameObject go, save1, save2, ground, ground_2, ground1, ground1_2;
	public string NameAnimation, NameAnimation2, NameAnimation3,NameAnimation4;
	public string NameAnimation5, NameAnimation6, NameAnimation7,NameAnimation8;
	public int pressed, onThePlatform;
	
    void Start()
    {
       rb = go.GetComponent<Rigidbody2D>();
		PlayerPrefs.DeleteKey("Pressed");
		grounded = GameObject.Find(this.name + "/grounded").transform;
		grounded_2 = GameObject.Find(this.name + "/grounded_2").transform;
		grounded1 = GameObject.Find(this.name + "/grounded1").transform;
		grounded1_2 = GameObject.Find(this.name + "/grounded1_2").transform;
		grounded2 = GameObject.Find(this.name + "/grounded2").transform;
		grounded2_2 = GameObject.Find(this.name + "/grounded2_2").transform;		//-270-450
		grounded3 = GameObject.Find(this.name + "/grounded3").transform;
		grounded3_2 = GameObject.Find(this.name + "/grounded3_2").transform; // -90-270 
		


   
    }

    // Update is called once per frame
	void Update(){
		rot = go.transform.rotation.eulerAngles.z;
		
		
	}
    void FixedUpdate()
    {
		
		
		
        isGround = Physics2D.Linecast(transform.position, grounded.position, layerMask);
		isGround_2 = Physics2D.Linecast(transform.position, grounded_2.position, layerMask);
		isGround1 = Physics2D.Linecast(transform.position, grounded1.position, layerMask);
		isGround1_2 = Physics2D.Linecast(transform.position, grounded1_2.position, layerMask);
		isGround2 = Physics2D.Linecast(transform.position, grounded2.position, layerMask);
		isGround2_2 = Physics2D.Linecast(transform.position, grounded2_2.position, layerMask);
		isGround3 = Physics2D.Linecast(transform.position, grounded3.position, layerMask);
		isGround3_2 = Physics2D.Linecast(transform.position, grounded3_2.position, layerMask);
		//if(Input.GetMouseButton(0)){
		if(Input.touchCount==1){
				
		//if (EventSystem.current.IsPointerOverGameObject() ||
    // EventSystem.current.currentSelectedGameObject == null){	
		 
            // Check if finger is over a UI element
           
		
		foreach(Touch touch in Input.touches){
			
		if(EventSystem.current.IsPointerOverGameObject(touch.fingerId)){
		//if(Input.touchCount>0 &&!UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId)){
		
		if(check==true){
				
			 Jump(); 
			 
			}
	}
	
	//}
	
		
	}
	}
		
	
		
		if(pressed==0 && onThePlatform==1){	
	if(check2 == true){
	pressed=5;
	PlayerPrefs.SetInt("Pressed", pressed);
	
	go.GetComponent<Animation>().Play(NameAnimation5);	
	
	}
			
	}
	if(check2 == false && pressed==5){
			pressed=3;
			PlayerPrefs.SetInt("Pressed", pressed);
		}
		
		if(check2 == false && pressed==6){
			pressed=1;
			PlayerPrefs.SetInt("Pressed", pressed);
		}
		
		if(check2 == false && pressed==7){
			pressed=2;
			PlayerPrefs.SetInt("Pressed", pressed);
		}
		
		if(check2 == false && pressed==8){
			pressed=0;
			PlayerPrefs.SetInt("Pressed", pressed);
		}
		
		
	if(pressed==1&& onThePlatform==1 ){	
	if(check2 == true){
	pressed=7;
	PlayerPrefs.SetInt("Pressed", pressed);
	
	go.GetComponent<Animation>().Play(NameAnimation7);	
		

	}
	}
	if(pressed==2&& onThePlatform==1 ){	
	if(check2 == true){
	pressed=8;
	PlayerPrefs.SetInt("Pressed", pressed);
	
	go.GetComponent<Animation>().Play(NameAnimation8);	
		

	}
	}
	if(pressed==3&& onThePlatform==1 ){	
	if(check2 == true){
	pressed=6;
	PlayerPrefs.SetInt("Pressed", pressed);
	
	go.GetComponent<Animation>().Play(NameAnimation6);	
		

	}
		
	}
		
    }
	public void Jump()
	{
		
	
	
	if(isGround || isGround_2){
	//if(rot>105 && rot<=180){		
						
if(Input.GetMouseButton(0)){
//if(touchCount>0){
		
			pressed=0;
				PlayerPrefs.SetInt("Pressed", pressed);
						
			//rb.velocity = speed * Vector2.up;
			rb.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
			//rb.AddForce(-transform.up * speed, ForceMode2D.Impulse);
			go.GetComponent<Animation>().Play(NameAnimation);
			onThePlatform = 0;
			PlayerPrefs.SetInt("OnPlatform", onThePlatform);
			
	
}	
}
	
	
	if(isGround1 || isGround1_2){
		//if(rot<=0){	
if(Input.GetMouseButton(0)){
	//if(touchCount>0){
			
			pressed =1;
			PlayerPrefs.SetInt("Pressed", pressed);
						
			//rb.velocity = speed * Vector2.up;
			rb.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
			//rb.AddForce(transform.up * speed, ForceMode2D.Impulse);
			go.GetComponent<Animation>().Play(NameAnimation2);
			onThePlatform = 0;
			PlayerPrefs.SetInt("OnPlatform", onThePlatform);
				
	}
}
	
	if(isGround2 || isGround2_2){
	//if(rot>5 && rot<=90){		
if(Input.GetMouseButton(0)){
//	if(touchCount>0){	
	
			pressed =3;
			PlayerPrefs.SetInt("Pressed", pressed);
						
			//rb.velocity = speed * Vector2.up;
			//rb.AddForce(Vector3.up * (speed * rb.mass*rb.gravityScale * 10f));
			rb.AddForce(transform.right * speed, ForceMode2D.Impulse);
			go.GetComponent<Animation>().Play(NameAnimation4);
			onThePlatform = 0;
			PlayerPrefs.SetInt("OnPlatform", onThePlatform);
		
	
}
	}
	if(isGround3 || isGround3_2){
		//if(rot>205 && rot<=270){			
if(Input.GetMouseButton(0)){
	//if(touchCount>0){
			
			pressed =2;
			PlayerPrefs.SetInt("Pressed", pressed);
						
			//rb.velocity = speed * Vector2.up;
			//rb.AddForce(Vector3.up * (speed * rb.mass*rb.gravityScale * 10f));
			rb.AddForce(-transform.right * speed, ForceMode2D.Impulse);
			go.GetComponent<Animation>().Play(NameAnimation3);
			onThePlatform = 0;
			PlayerPrefs.SetInt("OnPlatform", onThePlatform);
		
	
}
	}
	}

void OnTriggerEnter2D(Collider2D col){
	
pressed = PlayerPrefs.GetInt("Pressed");
			if(col.gameObject.tag == "onPlatform"){
	onThePlatform = 1;
	PlayerPrefs.SetInt("OnPlatform", onThePlatform);

	}
	
	if(col.gameObject.tag == "block1"){
		check = true;
		rb.velocity = Vector3.zero;
		rb.angularVelocity = 0f;
		//CamMove = 1;
		//PlayerPrefs.SetInt("CamMove", CamMove);
	}
	if(col.gameObject.tag == "block2"){
	check2 = true;

	}
	if(col.gameObject.tag == "block4"){
		//Physics2D.IgnoreCollision(col.GetComponent<Collider2D>(), GetComponent<Collider2D>());
		//	rb.velocity = Vector3.zero;
		//rb.angularVelocity = 0f;
		
		
	}
}
void OnTriggerExit2D(Collider2D col){
	
if(col.gameObject.tag == "onPlatform"){
	onThePlatform = 0;
	PlayerPrefs.SetInt("OnPlatform", onThePlatform);

	}
	
	if(col.gameObject.tag == "block1"){
		check = false;
		//CamMove = 0;
		//PlayerPrefs.SetInt("CamMove", CamMove);
		
	}
	if(col.gameObject.tag == "block4"){
	rb.velocity = Vector3.zero;
		rb.angularVelocity = 0f;	
		
	}
		if(col.gameObject.tag == "block2"){
		check2 = false;

	}
}





}
