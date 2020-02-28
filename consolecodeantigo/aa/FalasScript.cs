/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 21/02/2020
 * Time: 17:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace Dialogos_Teste
{
	/*	Esse é o script em que todos os diálogos ficarão
		Eles vão ficar organizados com IDs específicas e a descrição de quando serão usados
			para melhor entendimento enquanto no está sendo usado no Console. 
		(Não sei se ficará assim, provavel que mude na versão final)
	 */
	public static class FalasScript
	{
		//ex.: Diálogo com um aldeão aleatório - id1
		public static string[] id1 = {"A: Opa! Eae, man!", 
									  "B: Eae, blz?", 
									  "A: Nah, não sei o que escrever de exemplo pros diálogos.", 
									  "B: Escreve qualquer coisa ae, é só exemplo mesmo."};
        
		//ex.: Diálogo com o ex-militar - id2
        public static string[] id2 = {"A: Hey, decidi fazer o que tu recomendou.", 
									  "B: Namoral, fodase.", 
									  "A: Fodase fodase", 
									  "B: Excuse me, WTF?!"};
		
		public static List<Item> caixadialogo;
 
	 	static void Start(){
	    	caixadialogo = new List<FalasScript>(){
	        	new FalasScript() {
	                charName = "Zezinho", 
                	charFala = "Opa! Eae, man!",
	                //charImage = iconezezinho
	           },
	            new FalasScript() {
	                charName = "OmanLa", 
                	charFala = "Eae, blz?",
	                //charImage = iconezezinho
				}
			};
		}
    }
}