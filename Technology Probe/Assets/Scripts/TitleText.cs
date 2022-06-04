using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TitleText : MonoBehaviour
{
	public TMP_Text txt;
	
    // Start is called before the first frame update
	public int i = 0;
	public string[] titles = {"Auto", "Fahrrad", "Avocado", "Apfel", "Atomkraftwerk", "Windkraftwerk", "Flugzeug", "Zug"};
    void Start()
    {
		txt = GetComponent<TMP_Text> ();
		txt.text = titles[i];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
    public void changeTitleFront()
    {
		i++;
        txt.text = titles[i-1];
		if(i>7)
		{
			i = 0;
		}
    }
	
	
    public void changeTitleBack()
    {
		i--;
        txt.text = titles[i+1];
		if(i<0)
		{
			i = 7;
		}
    }
}
