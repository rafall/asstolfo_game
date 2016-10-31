using UnityEngine;
using System.Collections;

public class IntroSubtitle: MonoBehaviour {

	private UnityEngine.UI.Text subtitle;
	private float startTime;

	private int textAmount;

	private string[] text;
	private float[] timeText;

	private int currentText;

	// Use this for initialization
	void Start () {
		textAmount = 14;
		text = new string[textAmount];
		timeText = new float[textAmount];

		text[0] = "EM UMA NOITE DE HALLOWEEN";
		text[1] = "PASSEANDO PELAS RUAS, ESTAVA ASSTOLFO";
		text[2] = "UMA CRIANCINHA INOCENTE E PURA DE CORAÇÃO";
		text[3] = "QUANDO...";
		text[4] = "ELE PERDEU SUA QUERIDA MÁSCARA DO DOKU DOKU";
		text[5] = "DE REPENTE";
		text[6] = "VIU UM VULTO COM SUA MÁSCARA";
		text[7] = "CORRENDO PARA UMA CASA ABANDONADA";
		text[8] = "COMO ASSTOLFO TEM VERGONHA DO SEU ROSTO";
		text[9] = "ELE TIROU AS BALAS DO SEU SAQUINHO DE PAPEL";
		text[10] = "E ENCONBRIU SUA FACE COM ELE";
		text[11] = "E AGORA?";
		text[12] = "O QUE FAZER?";
		text[13] = "ATERRORIZADO, ELE DECIDE SEGUIR O DESCONHECIDO...";

		timeText[0] = 0.0f;
		timeText[1] = 1.9f;
		timeText[2] = 4.9f;
		timeText[3] = 7.8f;
		timeText[4] = 10.0f;
		timeText[5] = 12.8f;
		timeText[6] = 14.0f;
		timeText[7] = 16.0f;
		timeText[8] = 18.5f;
		timeText[9] = 21.0f;
		timeText[10] = 23.5f;
		timeText[11] = 25.7f;
		timeText[12] = 26.7f;
		timeText[13] = 28.2f;

		subtitle = GetComponent<UnityEngine.UI.Text> ();
		startTime = Time.realtimeSinceStartup;

		currentText = 0;
		subtitle.text = text[currentText];
	}
	
	// Update is called once per frame
	void Update () {
		float timePassed = Time.realtimeSinceStartup - startTime;

		if (timePassed > timeText[currentText + 1]) {
			currentText++;
			subtitle.text = text[currentText];
		}
	}
}
