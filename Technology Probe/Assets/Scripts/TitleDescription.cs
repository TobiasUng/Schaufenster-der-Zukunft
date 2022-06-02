using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TitleDescription : MonoBehaviour
{
	public TMP_Text txt;
	
    // Start is called before the first frame update
	public int i = 0;
	public string[] titles = {"Hier soll stehen", "Dafür wissen wir", "Ein Test Objekt", "Mal was anderes", "Jetzt kommt das", "Könnt ihr lesen", "Deswegen dieser Text", "Nicht schon wieder"};
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
