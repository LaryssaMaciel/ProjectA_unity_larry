using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SpeakerUI : MonoBehaviour {
	
	public Image charPic;
	public Text fullName, dialog;
	
	private Character speaker;
	
	public Character Speaker {
		get{ return speaker; }
		set{ speaker = value; }
	}
	
	public string Dialog { set { dialog.text = value; } } //dialogo setado na narrativa
	public string CharName { set { fullName.text = value; } } //nome setado na narrativa
	public Sprite CharFoto { set { charPic.sprite = value; } } //imagem setada na narrativa
	
	//pega o personagem, parte da gambiarra, sorry again
	public bool HasSpeaker() { return speaker != null; }
	public bool SpeakerIs(Character chara) { return speaker == chara; }  
	
	public void Show() { gameObject.SetActive(true); } //mostra gameobject
	public void Hide() { gameObject.SetActive(false); }//hide gamobject
}
