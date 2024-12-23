using Microsoft.Xna.Framework;
using System;

namespace HadMonogame.Skripts.others
{
    internal class RotationDraw
    {
        public static readonly float[] HeadRotation = { 3.14f, 0f, 1.57f, 4.71f };
        public static readonly float[] MissileRotation = { 1.57f, 4.73f, 0f, 3.13f };            //down, up , right, left


        public static readonly int[] HeadRotationVector = { 515, 510, 0, 0, 3, 515, 512, -5 };
        public static readonly int[] MissileRotationVector = { -450, 620, 150, -125, -500, -85, 200, 600 };            //down, up , right, left

        public static float Rotation(float[] arrRotation, string smer)
        {
            if (arrRotation.Length == 4)
                switch (smer)
                {
                    case ("down"):
                        return arrRotation[0];
                    case ("up"):
                        return arrRotation[1];
                    case ("right"):
                        return arrRotation[2];
                    case ("left"):
                        return arrRotation[3];
                    default: return 0f;
                }
            else throw new ArgumentException("Array musí mít 4 čísla.");

        }

        public static Vector2 RotationVector(int[] arrVector, string smer)
        {

            if (arrVector.Length == 8)
            {
                switch (smer)
                {
                    case ("down"):
                        return new Vector2(arrVector[0], arrVector[1]);
                    case ("up"):
                        return new Vector2(arrVector[2], arrVector[3]);
                    case ("right"):
                        return new Vector2(arrVector[4], arrVector[5]);
                    case ("left"):
                        return new Vector2(arrVector[6], arrVector[7]);
                    default: return new Vector2(0, 0);
                }
            }
            else throw new ArgumentException("Array musí mít 8 čísel.");
        }



















    }
}
