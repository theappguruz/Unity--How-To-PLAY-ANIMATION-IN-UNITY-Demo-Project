using UnityEngine;
using System.Collections;

public class AnimatorControllerScript : MonoBehaviour 
{
	private Animator animator;
	private float speed;
	
	void Start () 
	{
		animator = gameObject.GetComponent<Animator>();
		StartCoroutine(setSpeed());
	}
	
	//Following enumerator just change the value of Animation Parameter randomly
	IEnumerator setSpeed()
	{
		yield return new WaitForSeconds(1.0f);
		speed = Random.Range(0,3.0f);
		//This line set the value of Animation Parameter 
		animator.SetFloat("StickmanSpeed",speed);
		StartCoroutine(setSpeed());
	}	
}