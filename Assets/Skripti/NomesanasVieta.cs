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

					case "b2":
						objektuSkripts.skanasAvots.
						PlayOneShot (objektuSkripts.skanaKoAtskanot [4]);
						break;

					case "cementMasin":
						objektuSkripts.skanasAvots.
						PlayOneShot (objektuSkripts.skanaKoAtskanot [5]);
						break;

					case "e46":
						objektuSkripts.skanasAvots.
						PlayOneShot (objektuSkripts.skanaKoAtskanot [6]);
						break;

					case "e61":
						objektuSkripts.skanasAvots.
						PlayOneShot (objektuSkripts.skanaKoAtskanot [7]);
						break;

					case "Ekskav":
						objektuSkripts.skanasAvots.
						PlayOneShot (objektuSkripts.skanaKoAtskanot [8]);
						break;

					case "policija":
						objektuSkripts.skanasAvots.
						PlayOneShot (objektuSkripts.skanaKoAtskanot [9]);
						break;

					case "Trakt1":
						objektuSkripts.skanasAvots.
						PlayOneShot (objektuSkripts.skanaKoAtskanot [10]);
						break;

					case "Trakt5":
						objektuSkripts.skanasAvots.
						PlayOneShot (objektuSkripts.skanaKoAtskanot [11]);
						break;

					case "ugunsdzes":
						objektuSkripts.skanasAvots.
						PlayOneShot (objektuSkripts.skanaKoAtskanot [12]);
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

				case "b2":
					objektuSkripts.b2.GetComponent<RectTransform> ().localPosition = objektuSkripts.b2Koord;
					break;

				case "cementMasin":
					objektuSkripts.cementaMasina.GetComponent<RectTransform> ().localPosition = objektuSkripts.cementKoord;
					break;

				case "e46":
					objektuSkripts.e46.GetComponent<RectTransform> ().localPosition = objektuSkripts.e46Koord;
					break;

				case "e61":
					objektuSkripts.e61.GetComponent<RectTransform> ().localPosition = objektuSkripts.e61Koord;
					break;

				case "Ekskav":
					objektuSkripts.Ekskavators.GetComponent<RectTransform> ().localPosition = objektuSkripts.EkskavKoord;
					break;

				case "policija":
					objektuSkripts.policija.GetComponent<RectTransform> ().localPosition = objektuSkripts.PolicKoord;
					break;

				case "Trakt1":
					objektuSkripts.traktors1.GetComponent<RectTransform> ().localPosition = objektuSkripts.trakt1Koord;
					break;

				case "Trakt5":
					objektuSkripts.traktors5.GetComponent<RectTransform> ().localPosition = objektuSkripts.trakt5Koord;
					break;

				case "ugunsdzes":
					objektuSkripts.ugunsdzeseji.GetComponent<RectTransform> ().localPosition = objektuSkripts.ugunsdzesKoord;
					break;

				default:
				Debug.Log ("Tags netika atpazits!");    
				break;
				
				}
			}
		}
	}
}
