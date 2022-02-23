using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {

	public GameObject CepuresPNG;
	public GameObject CepuresPNG2;
	public GameObject ZabakiPNG1;
	public GameObject ZabakiPNG2;
	public GameObject BiksesPNG1;
	public GameObject BiksesPNG2;
	public GameObject LadePNG1;
	public GameObject LadePNG2;
	public GameObject mainigaisAttels;
	public Sprite[] atteluMasivs;

	public void CepuresPNGparadisana (bool vertiba){
		CepuresPNG.SetActive (vertiba);
	}
	public void CepuresPNG2paradisana (bool vertiba){
		CepuresPNG2.SetActive (vertiba);
	}
	public void ZabakiPNG1paradisana (bool vertiba){
		ZabakiPNG1.SetActive (vertiba);
	}
	public void ZabakiPNG2paradisana (bool vertiba){
		ZabakiPNG2.SetActive (vertiba);
	}
	public void BiksesPNG1paradisana (bool vertiba){
		BiksesPNG1.SetActive (vertiba);
	}
	public void BiksesPNG2paradisana (bool vertiba){
		BiksesPNG2.SetActive (vertiba);
	}
	public void LadePNG1paradisana (bool vertiba){
		LadePNG1.SetActive (vertiba);
	}
	public void LadePNG2paradisana (bool vertiba){
		LadePNG2.SetActive (vertiba);
	}
}

