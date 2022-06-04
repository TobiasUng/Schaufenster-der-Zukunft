using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TitleDescription : MonoBehaviour
{
	public TMP_Text txt;
	
    // Start is called before the first frame update
	public int i = 0;
	public string[] titles = {"Gemütliche Fahrt <br> Stau <br> Schädliche Abgase", "Gleichzeitig eine sportliche Aktivität <br> Keine Abgase <br> Einsatz abhängig von Wetter und Länge des Weges",
	"Meist importiert aus Chile <br> 1kg (2-3 Stück) benötigt 1000l Wasser <br> Gesundes “superfood”", "In Österreich angebaut <br> Gesund <br> Kein “exotischer” Geschmack wie bei importierten Früchten",
	"Benötigt wenig Brennstoff für viel Energie <br> Weniger Emissionen <br> Risiko eines Reaktorunfalls", "Erneuerbare Energie <br> Wind is nicht immer verfügbar (nur Unterstützende Rolle) <br> Saubere Energiequelle",
	"Schädliche Abgase <br> Kürzere Reisezeit als Zug <br> Jedes Ziel erreichbar", "Klimafreundlich reisen <br> Längere Reisezeit als Flugzeug <br> Manche Ziele nicht erreichbar"};
    void Start()
    {
		txt = GetComponent<TMP_Text> ();
		txt.text = titles[i];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
    public void changeDescrFront()
    {
		i++;
        txt.text = titles[i-1];
		if(i>7)
		{
			i = 0;
		}
    }
	
	
    public void changeDescrBack()
    {
		i--;
        txt.text = titles[i+1];
		if(i<0)
		{
			i = 7;
		}
    }
}
