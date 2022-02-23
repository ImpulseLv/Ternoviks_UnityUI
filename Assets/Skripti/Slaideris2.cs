using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slaideris2 : MonoBehaviour {

	public GameObject slaideris;
	public GameObject mainigaisAttels;

	public void mainitPlatumu(){
		float pasreizejaVertiba = slaideris.GetComponent<Slider> ().value;
		mainigaisAttels.transform.localScale = new Vector2 (1F * pasreizejaVertiba, 1);
	}
}
