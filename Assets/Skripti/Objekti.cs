using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidzibaMasina;
	public GameObject autobussaMasina;

	[HideInInspector]
	public Vector2 atkrMKoord;
    [HideInInspector]
	public Vector2 atraPKoord;
	[HideInInspector]
	public Vector2 abuusMKoord;
	public Canvas kanva;
	public AudioSource audioAvots;
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;
	public GameObject pedejaisVilktais = null;


	// Use this for initialization
	void Start () {
		atkrMKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
		atraPKoord = atraPalidzibaMasina.GetComponent<RectTransform>().localPosition;
		abuusMKoord = autobussaMasina.GetComponent<RectTransform>().localPosition;
	}
	
}
