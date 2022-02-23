using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstaParadisana : MonoBehaviour {

	public string teksts;
	public string teksts2;
	public GameObject ievadesLauks;
	public GameObject ievadesLauks2;
	public GameObject tekstaAttelosana;

	public void uzglabaTekstu(){
		teksts2 = ievadesLauks2.GetComponent<Text> ().text;
		teksts = ievadesLauks.GetComponent<Text> ().text;
		tekstaAttelosana.GetComponent<Text>().text = "Minecraft varonis "+teksts.ToUpper()+","+teksts2+" gadi!";
	}
}
