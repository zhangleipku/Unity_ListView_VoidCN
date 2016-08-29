using UnityEngine;
using System.Collections;

public class ListViewController : MonoBehaviour {

	[SerializeField]
	GameObject prefab = null;

	void Start () 
	{
		for(int i = 0; i < 5; i++)
		{
			GameObject instance = (GameObject)Instantiate(prefab);

			instance.transform.SetParent(transform, false);

			instance.tag = "ListCell";

			ListCellController lcc = instance.GetComponentInChildren<ListCellController> ();

			if (lcc) {
				lcc.lblBody.text = i.ToString ();
			}
		}
	}
	

	void Update () {
		
	}
}
