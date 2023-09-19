using System.Collections;
using UnityEngine;
public class CameraFollow : followObj
{
    [SerializeField] public Vector3 DefaultCamPOS;
    [SerializeField] protected Quaternion DefaultCamROS;
    protected override void follow()
    {
        if(Obj == null) return;
        Vector3 thisPos = Vector3.Lerp(this.transform.parent.position, new Vector3(0,Obj.position.y,Obj.position.z) + DefaultCamPOS , this.smooth * Time.deltaTime);
        this.transform.parent.position = thisPos;
    }
}
