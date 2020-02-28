using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")] //cria novos personagens
public class Character : ScriptableObject {
	public string fullName; //nome do personagem
	public Sprite charPic; //e sua respectiva foto
}
