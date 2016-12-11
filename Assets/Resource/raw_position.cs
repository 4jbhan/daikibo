using UnityEngine;
using System.Collections;

public class raw_position : MonoBehaviour {

    public Vector3[,] cordinates = new Vector3[8,8];

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void data_setter()
    {
        cordinates[0, 0] = new Vector3((float)3.159854, (float)-9.396926, (float)1.308854);
        cordinates[1, 0] = new Vector3((float)1.308854, (float)-9.396926, (float)3.159854);
        cordinates[2, 0] = new Vector3((float)-1.308854, (float)-9.396926, (float)3.159854);
        cordinates[3, 0] = new Vector3((float)-3.159854, (float)-9.396926, (float)1.308854);
        cordinates[4, 0] = new Vector3((float)-3.159854, (float)-9.396926, (float)-1.308854);
        cordinates[5, 0] = new Vector3((float)-1.308854, (float)-9.396926, (float)-3.159854);
        cordinates[6, 0] = new Vector3((float)1.308854, (float)-9.396926, (float)-3.159854);
        cordinates[7, 0] = new Vector3((float)3.159854, (float)-9.396926, (float)-1.308854);
        cordinates[0, 1] = new Vector3((float)5.938583, (float)-7.660444, (float)2.459842);
        cordinates[1, 1] = new Vector3((float)2.459842, (float)-7.660444, (float)5.938583);
        cordinates[2, 1] = new Vector3((float)-2.459842, (float)-7.660444, (float)5.938583);
        cordinates[3, 1] = new Vector3((float)-5.938583, (float)-7.660444, (float)2.459842);
        cordinates[4, 1] = new Vector3((float)-5.938583, (float)-7.660444, (float)-2.459842);
        cordinates[5, 1] = new Vector3((float)-2.459842, (float)-7.660444, (float)-5.938583);
        cordinates[6, 1] = new Vector3((float)2.459842, (float)-7.660444, (float)-5.938583);
        cordinates[7, 1] = new Vector3((float)5.938583, (float)-7.660444, (float)-2.459842);
        cordinates[0, 2] = new Vector3((float)8.001031, (float)-5.000000, (float)3.314136);
        cordinates[1, 2] = new Vector3((float)3.314136, (float)-5.000000, (float)8.001031);
        cordinates[2, 2] = new Vector3((float)-3.314136, (float)-5.000000, (float)8.001031);
        cordinates[3, 2] = new Vector3((float)-8.001031, (float)-5.000000, (float)3.314136);
        cordinates[4, 2] = new Vector3((float)-8.001031, (float)-5.000000, (float)-3.314136);
        cordinates[5, 2] = new Vector3((float)-3.314136, (float)-5.000000, (float)-8.001031);
        cordinates[6, 2] = new Vector3((float)3.314136, (float)-5.000000, (float)-8.001031);
        cordinates[7, 2] = new Vector3((float)8.001031, (float)-5.000000, (float)-3.314136);
        cordinates[0, 3] = new Vector3((float)9.098437, (float)-1.736482, (float)3.768696);
        cordinates[1, 3] = new Vector3((float)3.768696, (float)-1.736482, (float)9.098437);
        cordinates[2, 3] = new Vector3((float)-3.768696, (float)-1.736482, (float)9.098437);
        cordinates[3, 3] = new Vector3((float)-9.098437, (float)-1.736482, (float)3.768696);
        cordinates[4, 3] = new Vector3((float)-9.098437, (float)-1.736482, (float)-3.768696);
        cordinates[5, 3] = new Vector3((float)-3.768696, (float)-1.736482, (float)-9.098437);
        cordinates[6, 3] = new Vector3((float)3.768696, (float)-1.736482, (float)-9.098437);
        cordinates[7, 3] = new Vector3((float)9.098437, (float)-1.736482, (float)-3.768696);
        cordinates[0, 4] = new Vector3((float)9.098437, (float)1.736482, (float)3.768696);
        cordinates[1, 4] = new Vector3((float)3.768696, (float)1.736482, (float)9.098437);
        cordinates[2, 4] = new Vector3((float)-3.768696, (float)1.736482, (float)9.098437);
        cordinates[3, 4] = new Vector3((float)-9.098437, (float)1.736482, (float)3.768696);
        cordinates[4, 4] = new Vector3((float)-9.098437, (float)1.736482, (float)-3.768696);
        cordinates[5, 4] = new Vector3((float)-3.768696, (float)1.736482, (float)-9.098437);
        cordinates[6, 4] = new Vector3((float)3.768696, (float)1.736482, (float)-9.098437);
        cordinates[7, 4] = new Vector3((float)9.098437, (float)1.736482, (float)-3.768696);
        cordinates[0, 5] = new Vector3((float)8.001031, (float)5.000000, (float)3.314136);
        cordinates[1, 5] = new Vector3((float)3.314136, (float)5.000000, (float)8.001031);
        cordinates[2, 5] = new Vector3((float)-3.314136, (float)5.000000, (float)8.001031);
        cordinates[3, 5] = new Vector3((float)-8.001031, (float)5.000000, (float)3.314136);
        cordinates[4, 5] = new Vector3((float)-8.001031, (float)5.000000, (float)-3.314136);
        cordinates[5, 5] = new Vector3((float)-3.314136, (float)5.000000, (float)-8.001031);
        cordinates[6, 5] = new Vector3((float)3.314136, (float)5.000000, (float)-8.001031);
        cordinates[7, 5] = new Vector3((float)8.001031, (float)5.000000, (float)-3.314136);
        cordinates[0, 6] = new Vector3((float)5.938583, (float)7.660444, (float)2.459842);
        cordinates[1, 6] = new Vector3((float)2.459842, (float)7.660444, (float)5.938583);
        cordinates[2, 6] = new Vector3((float)-2.459842, (float)7.660444, (float)5.938583);
        cordinates[3, 6] = new Vector3((float)-5.938583, (float)7.660444, (float)2.459842);
        cordinates[4, 6] = new Vector3((float)-5.938583, (float)7.660444, (float)-2.459842);
        cordinates[5, 6] = new Vector3((float)-2.459842, (float)7.660444, (float)-5.938583);
        cordinates[6, 6] = new Vector3((float)2.459842, (float)7.660444, (float)-5.938583);
        cordinates[7, 6] = new Vector3((float)5.938583, (float)7.660444, (float)-2.459842);
        cordinates[0, 7] = new Vector3((float)3.159854, (float)9.396926, (float)1.308854);
        cordinates[1, 7] = new Vector3((float)1.308854, (float)9.396926, (float)3.159854);
        cordinates[2, 7] = new Vector3((float)-1.308854, (float)9.396926, (float)3.159854);
        cordinates[3, 7] = new Vector3((float)-3.159854, (float)9.396926, (float)1.308854);
        cordinates[4, 7] = new Vector3((float)-3.159854, (float)9.396926, (float)-1.308854);
        cordinates[5, 7] = new Vector3((float)-1.308854, (float)9.396926, (float)-3.159854);
        cordinates[6, 7] = new Vector3((float)1.308854, (float)9.396926, (float)-3.159854);
        cordinates[7, 7] = new Vector3((float)3.159854, (float)9.396926, (float)-1.308854);
    }
}
