using UnityEngine;
using System.Collections;

public class ListViewController : MonoBehaviour {

	[SerializeField]
//	Transform prefab = null;
	GameObject prefab = null;

	void Start () 
	{
		for(int i=0; i<5; i++)
		{
			GameObject instance = (GameObject)Instantiate(prefab);

			instance.transform.SetParent(transform, false);

			instance.tag = "ListCell";

			ListCellController lcc = instance.GetComponentInChildren<ListCellController> ();

			if (lcc) {
				lcc.lblBody.text = i.ToString ();
			}

//			var text = item.GetComponentInChildren<Text>();
//			text.text = "item:" + i.ToString();

			//GameObject.gameObject.tag="Player";
			//gameObject.tag should be enough.
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		var a = this.GetComponentsInChildren<RectTransform>();

		var b = GameObject.FindGameObjectsWithTag ("ListCell");

	}
}
