using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slaideris : MonoBehaviour {

	public GameObject slaideris;
	public GameObject mainigaisAttels;

	public void mainitGarumu(){
		float pasreizejaVertiba = slaideris.GetComponent<Slider> ().value;
		mainigaisAttels.transform.localScale = new Vector2 (1 ,1F * pasreizejaVertiba);
	}
}
