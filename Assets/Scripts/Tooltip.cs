using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour {

    private Text tooltipText;

	void Start () {
        tooltipText = GetComponentInChildren<Text>();

        gameObject.SetActive(false);
	}
	
	public void GenerateTooltip(Item item) {
        string statText = "";

        foreach (var stat in item.stats) {
            statText += "\n" + stat.Key + ": " + stat.Value;
        }

        string tooltip = string.Format("<b>{0}</b>\n{1}\n{2}", item.title, item.description, statText);

        tooltipText.text = tooltip;

        gameObject.SetActive(true);
    }
}
