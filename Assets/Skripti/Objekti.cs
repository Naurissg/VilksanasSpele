using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	//Uzglabas visus velkamos objektus
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject b2;
	public GameObject cementaMasina;
	public GameObject e46;
	public GameObject e61;
	public GameObject Ekskavators;
	public GameObject policija;
	public GameObject traktors1;
	public GameObject traktors5;
	public GameObject ugunsdzeseji;


	//uzglabas katra transortlidzekla sakotnejo atraśanas vietu
	[HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atrPKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 b2Koord;
	[HideInInspector]
	public Vector2 cementKoord;
	[HideInInspector]
	public Vector2 e46Koord;
	[HideInInspector]
	public Vector2 e61Koord;
	[HideInInspector]
	public Vector2 EkskavKoord;
	[HideInInspector]
	public Vector2 PolicKoord;
	[HideInInspector]
	public Vector2 trakt1Koord;
	[HideInInspector]
	public Vector2 trakt5Koord;
	[HideInInspector]
	public Vector2 ugunsdzesKoord;



	public Canvas kanva;
	//Uzglabas audio avotu, kura atskańot audio efektus
	public  AudioSource skanasAvots;
	//uzglabas audio failus
	public AudioClip[] skanaKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;
	[HideInInspector]
	public GameObject pedejaisVilktais = null;

	void Start (){
		//uzsakot speli piefikse kur sakotneji atrodas katra masina
		atkrMKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
		atrPKoord = atraPalidziba.GetComponent<RectTransform>().localPosition;
		bussKoord = autobuss.GetComponent<RectTransform>().localPosition;
		b2Koord = b2.GetComponent<RectTransform>().localPosition;
		cementKoord = cementaMasina.GetComponent<RectTransform>().localPosition;
		e46Koord = e46.GetComponent<RectTransform>().localPosition;
		e61Koord = e61.GetComponent<RectTransform>().localPosition;
		EkskavKoord = Ekskavators.GetComponent<RectTransform>().localPosition;
		PolicKoord = policija.GetComponent<RectTransform>().localPosition;
		trakt1Koord = traktors1.GetComponent<RectTransform>().localPosition;
		trakt5Koord = traktors5.GetComponent<RectTransform>().localPosition;
		ugunsdzesKoord = ugunsdzeseji.GetComponent<RectTransform>().localPosition;



	}
}
