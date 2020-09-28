using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SLIDE : MonoBehaviour
{
    public int count = 0;
	public bool check = false;
	public bool check1 = false;
	public bool check2 = false;
	public GameObject Right, Left, obj1, obj2, center;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(check==true){
			//obj1.transform.position=Vector3.Lerp(obj1.transform.position, Right.transform.position, 2f * Time.deltaTime);
			obj1.transform.position=Vector3.Lerp(obj1.transform.position, Left.transform.position, 2f * Time.deltaTime);
			obj2.transform.position=Vector3.Lerp(obj2.transform.position, center.transform.position, 2f * Time.deltaTime);
		}
		else if(check1==true){
			obj1.transform.position=Vector3.Lerp(obj1.transform.position, center.transform.position, 2f * Time.deltaTime);
			obj2.transform.position=Vector3.Lerp(obj2.transform.position, Right.transform.position, 2f * Time.deltaTime);
		}
		else if(check2==true){
			//obj1.transform.position=Vector3.Lerp(obj1.transform.position, Left.transform.position, 2f * Time.deltaTime);
			//obj2.transform.position=Vector3.Lerp(obj2.transform.position, Left.transform.position, 2f * Time.deltaTime);
		}
    }
	public void Right_click(){
		count++;
		if(count==1){
			check=true;
			check1=false;
			check2=false;
		}
		else if(count==0){
			check=false;
			check1=true;
			check2=false;
			
		}
		else{
			count=1;
		}
	}
	public void Left_click(){
		count--;
		if(count==0){
			check=false;
			check1=true;
			check2=false;
		}
		else if(count==-1){
			check=false;
			check1=false;
			check2=true;
		}
		else{
			count=-1;
		}
	}
}
