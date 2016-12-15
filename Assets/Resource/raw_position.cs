using UnityEngine;
using System.Collections;

public class raw_position : MonoBehaviour {
    public Vector3[,] rawPosition = new Vector3[8,8];

    public void setter()
    {
        rawPosition[0, 0] = new Vector3((float)3.159854, (float)-9.396926, (float)1.308854);
        rawPosition[0, 1] = new Vector3((float)1.308854, (float)-9.396926, (float)3.159854);
        rawPosition[0, 2] = new Vector3((float)-1.308854, (float)-9.396926, (float)3.159854);
        rawPosition[0, 3] = new Vector3((float)-3.159854, (float)-9.396926, (float)1.308854);
        rawPosition[0, 4] = new Vector3((float)-3.159854, (float)-9.396926, (float)-1.308854);
        rawPosition[0, 5] = new Vector3((float)-1.308854, (float)-9.396926, (float)-3.159854);
        rawPosition[0, 6] = new Vector3((float)1.308854, (float)-9.396926, (float)-3.159854);
        rawPosition[0, 7] = new Vector3((float)3.159854, (float)-9.396926, (float)-1.308854);
        rawPosition[1, 0] = new Vector3((float)5.938583, (float)-7.660444, (float)2.459842);
        rawPosition[1, 1] = new Vector3((float)2.459842, (float)-7.660444, (float)5.938583);
        rawPosition[1, 2] = new Vector3((float)-2.459842, (float)-7.660444, (float)5.938583);
        rawPosition[1, 3] = new Vector3((float)-5.938583, (float)-7.660444, (float)2.459842);
        rawPosition[1, 4] = new Vector3((float)-5.938583, (float)-7.660444, (float)-2.459842);
        rawPosition[1, 5] = new Vector3((float)-2.459842, (float)-7.660444, (float)-5.938583);
        rawPosition[1, 6] = new Vector3((float)2.459842, (float)-7.660444, (float)-5.938583);
        rawPosition[1, 7] = new Vector3((float)5.938583, (float)-7.660444, (float)-2.459842);
        rawPosition[2, 0] = new Vector3((float)8.001031, (float)-5.000000, (float)3.314136);
        rawPosition[2, 1] = new Vector3((float)3.314136, (float)-5.000000, (float)8.001031);
        rawPosition[2, 2] = new Vector3((float)-3.314136, (float)-5.000000, (float)8.001031);
        rawPosition[2, 3] = new Vector3((float)-8.001031, (float)-5.000000, (float)3.314136);
        rawPosition[2, 4] = new Vector3((float)-8.001031, (float)-5.000000, (float)-3.314136);
        rawPosition[2, 5] = new Vector3((float)-3.314136, (float)-5.000000, (float)-8.001031);
        rawPosition[2, 6] = new Vector3((float)3.314136, (float)-5.000000, (float)-8.001031);
        rawPosition[2, 7] = new Vector3((float)8.001031, (float)-5.000000, (float)-3.314136);
        rawPosition[3, 0] = new Vector3((float)9.098437, (float)-1.736482, (float)3.768696);
        rawPosition[3, 1] = new Vector3((float)3.768696, (float)-1.736482, (float)9.098437);
        rawPosition[3, 2] = new Vector3((float)-3.768696, (float)-1.736482, (float)9.098437);
        rawPosition[3, 3] = new Vector3((float)-9.098437, (float)-1.736482, (float)3.768696);
        rawPosition[3, 4] = new Vector3((float)-9.098437, (float)-1.736482, (float)-3.768696);
        rawPosition[3, 5] = new Vector3((float)-3.768696, (float)-1.736482, (float)-9.098437);
        rawPosition[3, 6] = new Vector3((float)3.768696, (float)-1.736482, (float)-9.098437);
        rawPosition[3, 7] = new Vector3((float)9.098437, (float)-1.736482, (float)-3.768696);
        rawPosition[4, 0] = new Vector3((float)9.098437, (float)1.736482, (float)3.768696);
        rawPosition[4, 1] = new Vector3((float)3.768696, (float)1.736482, (float)9.098437);
        rawPosition[4, 2] = new Vector3((float)-3.768696, (float)1.736482, (float)9.098437);
        rawPosition[4, 3] = new Vector3((float)-9.098437, (float)1.736482, (float)3.768696);
        rawPosition[4, 4] = new Vector3((float)-9.098437, (float)1.736482, (float)-3.768696);
        rawPosition[4, 5] = new Vector3((float)-3.768696, (float)1.736482, (float)-9.098437);
        rawPosition[4, 6] = new Vector3((float)3.768696, (float)1.736482, (float)-9.098437);
        rawPosition[4, 7] = new Vector3((float)9.098437, (float)1.736482, (float)-3.768696);
        rawPosition[5, 0] = new Vector3((float)8.001031, (float)5.000000, (float)3.314136);
        rawPosition[5, 1] = new Vector3((float)3.314136, (float)5.000000, (float)8.001031);
        rawPosition[5, 2] = new Vector3((float)-3.314136, (float)5.000000, (float)8.001031);
        rawPosition[5, 3] = new Vector3((float)-8.001031, (float)5.000000, (float)3.314136);
        rawPosition[5, 4] = new Vector3((float)-8.001031, (float)5.000000, (float)-3.314136);
        rawPosition[5, 5] = new Vector3((float)-3.314136, (float)5.000000, (float)-8.001031);
        rawPosition[5, 6] = new Vector3((float)3.314136, (float)5.000000, (float)-8.001031);
        rawPosition[5, 7] = new Vector3((float)8.001031, (float)5.000000, (float)-3.314136);
        rawPosition[6, 0] = new Vector3((float)5.938583, (float)7.660444, (float)2.459842);
        rawPosition[6, 1] = new Vector3((float)2.459842, (float)7.660444, (float)5.938583);
        rawPosition[6, 2] = new Vector3((float)-2.459842, (float)7.660444, (float)5.938583);
        rawPosition[6, 3] = new Vector3((float)-5.938583, (float)7.660444, (float)2.459842);
        rawPosition[6, 4] = new Vector3((float)-5.938583, (float)7.660444, (float)-2.459842);
        rawPosition[6, 5] = new Vector3((float)-2.459842, (float)7.660444, (float)-5.938583);
        rawPosition[6, 6] = new Vector3((float)2.459842, (float)7.660444, (float)-5.938583);
        rawPosition[6, 7] = new Vector3((float)5.938583, (float)7.660444, (float)-2.459842);
        rawPosition[7, 0] = new Vector3((float)3.159854, (float)9.396926, (float)1.308854);
        rawPosition[7, 1] = new Vector3((float)1.308854, (float)9.396926, (float)3.159854);
        rawPosition[7, 2] = new Vector3((float)-1.308854, (float)9.396926, (float)3.159854);
        rawPosition[7, 3] = new Vector3((float)-3.159854, (float)9.396926, (float)1.308854);
        rawPosition[7, 4] = new Vector3((float)-3.159854, (float)9.396926, (float)-1.308854);
        rawPosition[7, 5] = new Vector3((float)-1.308854, (float)9.396926, (float)-3.159854);
        rawPosition[7, 6] = new Vector3((float)1.308854, (float)9.396926, (float)-3.159854);
        rawPosition[7, 7] = new Vector3((float)3.159854, (float)9.396926, (float)-1.308854);
    }
}
