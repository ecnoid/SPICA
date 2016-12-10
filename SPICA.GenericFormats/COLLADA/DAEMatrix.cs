﻿using SPICA.Math3D;

using System.Text;
using System.Xml.Serialization;

namespace SPICA.GenericFormats.COLLADA
{
    public class DAEMatrix
    {
        [XmlAttribute] public string sid;

        [XmlText] public string data;

        public static DAEMatrix Identity
        {
            get
            {
                return new DAEMatrix { data = "1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1" };
            }
        }

        public void Set(params Matrix3x4[] Matrices)
        {
            StringBuilder SB = new StringBuilder();
            
            for (int i = 0; i < Matrices.Length; i++)
            {
                if (i < Matrices.Length - 1)
                    SB.Append(Matrices[i].ToSerializableString() + " 0 0 0 1 ");
                else
                    SB.Append(Matrices[i].ToSerializableString() + " 0 0 0 1");
            }

            data = SB.ToString();
        }
    }
}
