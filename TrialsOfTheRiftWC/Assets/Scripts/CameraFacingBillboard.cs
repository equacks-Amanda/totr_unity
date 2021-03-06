﻿/*  Camera Facing Billboard - Sam Caulker
 * 
 *  Desc:   Makes the player indicators follow the player and makes the canvas face the requested camera.
 *  
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class CameraFacingBillboard : MonoBehaviour {

	public Camera cam_Camera;
    public PlayerController pc_trackedPlayer;
    public Vector3 v3_offset;

    /*/////////////////////////////////////////////////////////////////////////////////////////////////////////////*/

    void Update() {
        transform.LookAt(transform.position + cam_Camera.transform.rotation * Vector3.forward,
            cam_Camera.transform.rotation * Vector3.up);
        transform.position = pc_trackedPlayer.transform.position + v3_offset;
    }
}