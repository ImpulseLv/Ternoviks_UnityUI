using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjektuParvietosana : MonoBehaviour, IPointerDownHandler, IDragHandler,IBeginDragHandler,IEndDragHandler {

	private RectTransform transformacijuLogs;
	public Canvas kanva;

	private void Awake(){
		transformacijuLogs = GetComponent<RectTransform> ();
	}

	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Kreisais klikskis uz parvietojama objekta!");
	}
	public void OnDrag(PointerEventData notikums){
		Debug.Log ("Objekts tiek parvietots!");
		transformacijuLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;
	}
	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Uzsakta objekta parvietosana!");
	}
	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("Pabeigta objekta parvietosana!");
	}

}
