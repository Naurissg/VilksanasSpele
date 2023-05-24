using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	//Uzglabas visus velkamos objektus
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;

	//uzglabas katra transortlidzekla sakotnejo atraśanas vietu
	[HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atrPKoord;
	[HideInInspector]
	public Vector2 bussKoord;

	public Canvas kanva;

	//Uzglabas audio avotu, kura atskańot audio efektus
	public  AudioSource skanasAvots;
	//uzglabas audio failus
	public AudioClip[] skanaKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;
	[HideInInspector]
	public GameObject pedejaisVilktais = null;

	void start (){
		//uzsakot speli piefikse kur sakotneji atrodas katra masina
		atkrMKoord = 
		atkritumuMasina.GetComponent<RectTransform>().localPosition;
		atrPKoord = 
		atkritumuMasina.GetComponent<RectTransform>().localPosition;
		bussKoord = 
		atkritumuMasina.GetComponent<RectTransform>().localPosition;
	}
}
