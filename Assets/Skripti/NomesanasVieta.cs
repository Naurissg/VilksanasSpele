using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class NomesanasVieta : MonoBehaviour, IDropHandler {
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmeruStarp, yIzmeruStarp;
	public Objekti objektuSkripts;


	public void OnDrop(PointerEventData eventData){
		if (eventData.pointerDrag != null) {
			if (eventData.pointerDrag.tag.Equals (tag)) {
				velkObjZRot = 
					eventData.pointerDrag.GetComponent<RectTransform> ().transform.eulerAngles.z;
				vietasZRot = 
					eventData.pointerDrag.GetComponent<RectTransform> ().transform.eulerAngles.z;
				rotacijasStarpiba = 
					Mathf.Abs (vietasZRot - velkObjZRot);

				velkObjIzm = eventData.pointerDrag.GetComponent<RectTransform> ().localScale;

				vietasIzm = GetComponent<RectTransform> ().localScale;

				xIzmeruStarp = Mathf.Abs (vietasIzm.x - velkObjIzm.x);
				yIzmeruStarp = Mathf.Abs (vietasIzm.y - velkObjIzm.y);

				Debug.Log ("Rotacijas starpiba: " + rotacijasStarpiba
				+ "\nx starpiba: " + xIzmeruStarp
				+ "\ny starpiba: " + yIzmeruStarp);

				if ((rotacijasStarpiba <= 6 ||
				    (rotacijasStarpiba >= 354 &&
				    rotacijasStarpiba <= 360)) &&
				    (xIzmeruStarp <= 0.1 && yIzmeruStarp <= 0.1)) {
					Debug.Log ("Nolikts pareizaja vieta!");
					objektuSkripts.vaiIstajaVieta = true;

					eventData.pointerDrag.
					GetComponent<RectTransform> ().anchoredPosition =
						GetComponent<RectTransform> ().anchoredPosition;

					eventData.pointerDrag.
					GetComponent<RectTransform> ().localPosition =
						GetComponent<RectTransform> ().localPosition;

					eventData.pointerDrag.
					GetComponent<RectTransform> ().localScale =
						GetComponent<RectTransform> ().localScale;

					switch (eventData.pointerDrag.tag) {
					case "atkritumi":
						objektuSkripts.skanasAvots.
						PlayOneShot (objektuSkripts.skanaKoAtskanot [1]);
						break;

					case "medicina":
						objektuSkripts.skanasAvots.
						PlayOneShot (objektuSkripts.skanaKoAtskanot [2]);
						break;

					case "buss":
						objektuSkripts.skanasAvots.
						PlayOneShot (objektuSkripts.skanaKoAtskanot [3]);
						break;


					default:
						Debug.Log ("Tags netika atpazits!");    
						break;
					}
				}
			}else{
				
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [0]);

				switch (eventData.pointerDrag.tag) {
				case "atkritumi":
					objektuSkripts.atkritumuMasina.GetComponent<RectTransform> ().localPosition = objektuSkripts.atkrMKoord;
				break;

				case "medicina":
					objektuSkripts.atraPalidziba.GetComponent<RectTransform> ().localPosition = objektuSkripts.atrPKoord;
				break;

				case "buss":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition = objektuSkripts.bussKoord;
				break;


				default:
				Debug.Log ("Tags netika atpazits!");    
				break;
				
				}
			}
		}
	}
}
