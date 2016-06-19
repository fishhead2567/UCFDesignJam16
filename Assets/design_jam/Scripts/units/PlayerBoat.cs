using UnityEngine;
using System.Collections;

public class PlayerBoat : Player, ITurnChangeGeneric {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        float xAxisValue = Input.GetAxis("Horizontal") * 0.02f;
        float yAxisValue = Input.GetAxis("Vertical") * 0.02f;
        if (Camera.current != null)
        {
            Camera.current.transform.Translate(new Vector3(xAxisValue, yAxisValue, 0.0f));
        }

    }
	
	public void TurnChange ()
	{
		if (Vector3.Distance(moveDestination, transform.position) > 0.1f) {
			transform.position += (moveDestination - transform.position).normalized * moveSpeed * Time.deltaTime;
			
			if (Vector3.Distance(moveDestination, transform.position) <= 0.1f) {
				transform.position = moveDestination;
				GameManager.instance.nextTurn();
			}
		}
	}
}
