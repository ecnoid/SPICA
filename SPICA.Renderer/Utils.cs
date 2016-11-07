﻿using OpenTK;
using OpenTK.Graphics.ES30;

namespace SPICA.Renderer
{
    static class Utils
    {
        public static Matrix4 EulerRotate(Vector3 Rotation)
        {
            Matrix4 RotXMtx = Matrix4.CreateRotationX(Rotation.X);
            Matrix4 RotYMtx = Matrix4.CreateRotationY(Rotation.Y);
            Matrix4 RotZMtx = Matrix4.CreateRotationZ(Rotation.Z);

            return RotXMtx * RotYMtx * RotZMtx;
        }

        public static void SetState(EnableCap Cap, bool Value)
        {
            if (Value)
                GL.Enable(Cap);
            else
                GL.Disable(Cap);
        }
    }
}