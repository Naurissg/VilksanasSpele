using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//jaieimporte lai varetu lietot visus I interface
using UnityEngine.EventSystems;


public class DragDropSkripts : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler{
	//Uzglabá norádi uz Objekta Skriptu
	public Objekti objektuSkripts;
	private CanvasGroup kanvasGrupa;
	private RectTransform velkObjRectTransf;

	public void OnBeginDrag(PointerEventData eventData){
		objektuSkripts.pedejaisVilktais = null;
		kanvasGrupa.alpha = 0.6f;
		kanvasGrupa.blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData eventData){
		velkObjRectTransf.anchoredPosition += eventData.delta / objektuSkripts.kanva.scaleFactor;
	}
	public void OnEndDrag (PointerEventData eventData){
		objektuSkripts.pedejaisVilktais = eventData.pointerDrag;
		kanvasGrupa.alpha = 1f;

		if (objektuSkripts.vaiIstajaVieta == false) {
			kanvasGrupa.blocksRaycasts = true;

		} else {
			objektuSkripts.pedejaisVilktais = null;
		}
		objektuSkripts.vaiIstajaVieta = false;
	}

	void Start () {
		//peiklust velkama objekta CnavasGroup komponentei
		kanvasGrupa = GetComponent<CanvasGroup>();
		//Pieklust velkama objekta RectTransform komponentei
		velkObjRectTransf = GetComponent<RectTransform>();
	}
}
