using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBtnClickEvent : MonoBehaviour {
	public void BtnClick(){
		SceneManager.LoadScene("FIRST");
	}
}
