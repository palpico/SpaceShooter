using UnityEngine;
using System.Collections;

public class Destroy_Boundary : MonoBehaviour
{
	void OnTriggerExit (Collider other) 
	{
		Destroy(other.gameObject);
	}
}