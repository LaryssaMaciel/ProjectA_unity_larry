/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 20/02/2020
 * Time: 20:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Dialogos_Teste
{
	/*	Basicamente esse é o manager dos diálogo  */
	class Program
	{
		public static int fala = 0; //ao incrementar, ajuda a chamar outras falas de acordo com o número da posição do array
        public static bool interage = false; //ao ficar true, o personagem interage com o npc
        public static string[] newdialogo = {""}; //vai pegar a cópia do diálogo do outro script
        
        public static void Main(string[] args){
        	CallID(); //chama o sistema de ID
        	
        	//aqui seria quando o player vai interagir com o npc, começando a conversa
        	Console.Write("I para interagir com NPC ");
        	string input = Convert.ToString(Console.ReadLine());
        	if(input == "i" || input == "I"){ interage = true; } //começa a interagir
            
        	Manager_Interacao(); //chama o manager de interação
        }
        
        public static void Manager_Dialogo(){ //gerencia os dialogos, loops pro Console printar
			Console.WriteLine(newdialogo[fala]); //dialogo inicial do array, já que começa da posição zero
        	fala++; //incrementa a posição do array
        	
        	while(fala != newdialogo.Length){ //eunquanto não for a última fala, começa o loop pra continuar o dialogo
        		//continuar ao apertar qualquer botão
        		Console.Write("Continuar "); 
        		string i = Convert.ToString(Console.ReadLine());
        				
        		Console.WriteLine(newdialogo[fala]); //mostra o diálogo seguinte
        		fala++; //incrementa a posição do array
        	}
        	
        	if(fala == newdialogo.Length){ //ao chegar no fim do array
        		//terminar ao apertar qualquer botão
        		Console.Write("Terminar "); 
        		string i = Convert.ToString(Console.ReadLine());
        				
        		fala = 0; //o array e o auxiliador resetam
        		//interage = false; //no unity, acho que a interação terminaria aqui
			}
        	//aqui chama outro diálogo pra saber se o code ta funcional
        	/* será deletado */
        	Console.Write("Deseja ver outro diálogo? [S/N] "); 
        	string input = Convert.ToString(Console.ReadLine());
        	if(input == "s" || input == "S") { CallID(); Manager_Dialogo(); }//
        	else { interage = false; } //termina o diálogo
        }
        
        public static void Manager_Interacao(){ //sistema de dialogo
        	switch(interage){
        		case true: 
        			Manager_Dialogo();
        			break;
        		case false:
        			break;
        	}
        }
        
        public static void CallID(){
        	//aqui chama quando um diálogo específico, provavel que no unity será diferente, tipo o npc passa um ID pro player ou algo assim, sla
        	Console.Write("Escolha o ID do diálogo (id1/id2) ");
        	string inputid = Convert.ToString(Console.ReadLine());
        	
        	//e aqui o dialogo x será clonado do outro script
        	switch(inputid){
        		case "id1":
        			newdialogo = (string[])FalasScript.id1.Clone();
        			break;
        		case "id2":
        			newdialogo = (string[])FalasScript.id2.Clone();
        			break;
        		default:
        			break;
        	}
        }
	}
}