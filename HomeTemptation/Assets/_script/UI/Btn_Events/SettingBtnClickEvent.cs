using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingBtnClickEvent : MonoBehaviour {
	public Image settingPanel;

	void start(){
	}

	public void OpenPanel(){
		settingPanel.gameObject.SetActive (true);
	}

	public void ClosePanel(){
		settingPanel.gameObject.SetActive (false);
	}
}
