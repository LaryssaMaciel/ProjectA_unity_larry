using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct Line { //vai criar as linhas dos dialogos com as opções nome, personagem e texto
	public string name;
	public Character character;
	public Sprite foto;
	[TextArea(2, 4)] //tamanho da area do texto
	public string text;
}

[CreateAssetMenu(fileName = "New Conversation", menuName = "Conversation")] //vai criar novos dialogos
public class Conversation : ScriptableObject{
	[Header("Pode colocar aleatório, é gambiarra")]
	public Character speaker, speaker1; //por enquanto, coloca personagem aleatório (desculpa pela gambiarra)
	public Line[] lines; //quantidade de dialogos pra configurar
}
