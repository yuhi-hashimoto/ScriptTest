using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	　　private int hp = 100;
	　　private int power = 25;
	　　private int mp = 53;
	　　

	　　public void Attack() {
		
		Debug.Log( this.power + "のダメージを与えた" );
	    }

	　　public void Defence(int damage) {
		　　　　
		this.hp -= damage;
		Debug.Log (damage + "のダメージを受けた");
	    }

	　　public void Magic(int usemp) {
		　　　　
		if (mp < usemp) {
			Debug.Log ("MPが足りないため魔法が使えない。");
		} else {
			this.mp -= usemp;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp);
		}
	}
}
	
public class Test : MonoBehaviour {

	　　void Start () {
		　　　　　　　
		Boss lastboss = new Boss ();

		lastboss.Attack ();
		lastboss.Defence (3);
		for (int i = 0; i < 10; i++) {
		lastboss.Magic (5);
	}
}

	// Update is called once per frame
	void Update () {
		
	}
}
