using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidzibaMasina;
	public GameObject autobussaMasina;
	public GameObject policijasMasina;
	public GameObject e61Masina;
	public GameObject e46Masina;
	public GameObject traktors1M;
	public GameObject traktors5M;
	public GameObject Ekskavators;
	public GameObject CementaM;
	public GameObject PabeigsanasLogs;
	public GameObject UgunsM;
	public GameObject zvaigzne1;
	public GameObject zvaigzne2;
	public GameObject zvaigzne3;

    [HideInInspector]
	public Vector2 atkrMKoord;
    [HideInInspector]
	public Vector2 atraPKoord;
	[HideInInspector]
	public Vector2 abuusMKoord;
    [HideInInspector]
    public Vector2 polMKoord;
	[HideInInspector]
	public Vector2 e61MKoord;
    [HideInInspector]
    public Vector2 e46MKoord;
	[HideInInspector]
	public Vector2 traktors1Koord;
	[HideInInspector]
	public Vector2 traktors5Koord;
	[HideInInspector]
	public Vector2 EkskavatorsKoord;
	[HideInInspector]
	public Vector2 CementaKoord;
	[HideInInspector]
	public Vector2 UgunsKoord;
    public Canvas kanva;
	public AudioSource audioAvots;
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;
	public GameObject pedejaisVilktais = null;
    public int punkti = 0;
    public float laiks;
    public bool laiksAktivs = true;
    public Text laikaParadisana;
    // Use this for initialization
    void Start () {
		polMKoord = policijasMasina.GetComponent<RectTransform>().localPosition;
		e61MKoord = e61Masina.gameObject.GetComponent<RectTransform>().localPosition;
		atkrMKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
		atraPKoord = atraPalidzibaMasina.GetComponent<RectTransform>().localPosition;
		abuusMKoord = autobussaMasina.GetComponent<RectTransform>().localPosition;
		e46MKoord = e46Masina.GetComponent <RectTransform>().localPosition;
		traktors1Koord = traktors1M.GetComponent<RectTransform>().localPosition;
		traktors5Koord = traktors5M.GetComponent<RectTransform>().localPosition;
		UgunsKoord = UgunsM.GetComponent<RectTransform>().localPosition;
		EkskavatorsKoord = Ekskavators.GetComponent<RectTransform>().localPosition;
		PabeigsanasLogs.SetActive (false);
		laikaParadisana.GetComponent<Text>().enabled = false;
	}
	
}
