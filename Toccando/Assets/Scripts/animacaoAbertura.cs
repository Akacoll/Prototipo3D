using UnityEngine;
using System.Collections;

public class animacaoAbertura : MonoBehaviour {

	public BoundingSphere esfera;

	public void objetos1()
	{
		//transform.Translate (Vector3.forward * 10 * Time.deltaTime);	
		//transform.Rotate (Vector3.up * 100 * Time.deltaTime);
		//bool f2 = false;

		float velocidade = 0.1f;
		float y = Camera.main.transform.position.y;

		if (y < 3) 
		{
			Camera.main.transform.position += transform.up * Time.deltaTime;

			//Vector3 v = Camera.main.transform.position;
			//v.y += Time.deltaTime * velocidade;
			//Camera.main.transform.position = v;
			//Camera.main.transform.up;
			//Time.deltaTime * velocidade;
			//Camera.main.transform.position.y = Time.deltaTime * 0.1;
			//Camera.main.transform.up * Time.deltaTime;
		}

		//if(esfera.position.y == )



		if (transform.rotation.x < 0.1) 
		{
			Camera.main.transform.RotateAround (transform.position, Vector3.right, Time.deltaTime * 5);

		}
		/*
		if (esfera.position.y <= -10 && Camera.main.transform.position.y < 20) 
		{
			//Camera.main.transform.position -= transform.up * 10;
			Camera.main.transform.position -= Vector3.up * 10;
		}
		*/
	}

	// Use this for initialization
	void Start () {
		
		//objetos1 ();
	}
	
	// Update is called once per frame
	void Update () {
		objetos1 ();
	}
}
