using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogDisplay : MonoBehaviour {

	public Conversation conversation; //var q chama do script conversation
	
	public GameObject speaker, speaker1; //os 2 gameobjects no canvas com os elementos dos dialogo
	
	private SpeakerUI speakerui, speakerui1; //
	
	private int activelineIndex = 0; //a linha atual do dialogo
	
	void Start () {
		speakerui = speaker.GetComponent<SpeakerUI>();
		speakerui1 = speaker1.GetComponent<SpeakerUI>();
	}
	
	void Update () {
		if(Input.GetKeyDown("space")) { AdvanceConversation(); } //avança o dialogo
	}
	
	void AdvanceConversation(){
		if(activelineIndex < conversation.lines.Length){ //enquanto não ta no fim do dialogo
			Character character = conversation.lines[activelineIndex].character; //segue a linha do dialogo
			if(speakerui.SpeakerIs(character)){ 
				SetDialog(speakerui, speakerui1, conversation.lines[activelineIndex].text, conversation.lines[activelineIndex].name, conversation.lines[activelineIndex].foto);
				speakerui1.Hide(); //hide dialogo pra começar o outro
			} else {  
				SetDialog(speakerui1, speakerui, conversation.lines[activelineIndex].text, conversation.lines[activelineIndex].name, conversation.lines[activelineIndex].foto);
				speakerui.Hide();
			}
			activelineIndex+= 1; //passa pra outra linha
		} else { //aqui fecha o dialogo e reseta o index quando terminar
			speakerui.Hide();
			speakerui1.Hide();
			activelineIndex = 0;
		}
	}
	
	//aqui seta o dialogo, foto e nome, e mostra na tela
	void SetDialog(SpeakerUI activeSpeakerUI, SpeakerUI inativeSpeakerUI, string text, string name, Sprite foto){
		activeSpeakerUI.Dialog = text;
		activeSpeakerUI.CharName = name;
		activeSpeakerUI.CharFoto = foto;
		activeSpeakerUI.Show();
	}
	
}
