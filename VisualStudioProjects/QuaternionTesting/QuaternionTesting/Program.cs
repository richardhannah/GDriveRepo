using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace QuaternionTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Quaternion initialQ = CreateFromYawPitchRoll(0, 180, 0);
            Quaternion targetQ = new Quaternion(0, 0, 0, 1);
            Quaternion errorQ = targetQ*Quaternion.Inverse(initialQ);
            Quaternion resultQ = errorQ * initialQ;
            //QTransition = QFinal * QInitial^{-1}

            Console.WriteLine("initial Quaternion");
            Console.WriteLine(printQ(initialQ));
            Console.WriteLine("Target Quaternion");
            Console.WriteLine(printQ(targetQ));
            Console.WriteLine("Error Quaternion");
            Console.WriteLine(printQ(errorQ));
            Console.WriteLine("==================");
            Console.WriteLine("Test");
            Console.WriteLine(printQ(resultQ));


            Console.ReadLine();

        }

        static string printQ(Quaternion qValue)
        {
            string returnVal;

            returnVal = "X: " + Math.Round(qValue.X, 7).ToString() + "\n" +
                        "Y: " + Math.Round(qValue.Y, 7).ToString() + "\n" +
                        "Z: " + Math.Round(qValue.Z, 7).ToString() + "\n";



            return returnVal;
        }

        //http://stackoverflow.com/questions/11492299/quaternion-to-euler-angles-algorithm-how-to-convert-to-y-up-and-between-ha

        public static Quaternion CreateFromYawPitchRoll( float yaw, float pitch, float roll)
        {
            /*
             * The quaternion for the rotation by angle a about unit vector (x1,y1,z1) is given by:

                cos(angle/2) + i ( x1 * sin(angle/2)) + j (y1 * sin(angle/2)) + k ( z1 * sin(angle/2))
             * http://www.euclideanspace.com/maths/geometry/rotations/conversions/eulerToQuaternion/
             * 
             * 
             */
            //float roll



            float rollOver2 = roll * 0.5f;
            float sinRollOver2 = (float)Math.Sin((double)rollOver2);
            float cosRollOver2 = (float)Math.Cos((double)rollOver2);
            float pitchOver2 = pitch * 0.5f;
            float sinPitchOver2 = (float)Math.Sin((double)pitchOver2);
            float cosPitchOver2 = (float)Math.Cos((double)pitchOver2);
            float yawOver2 = yaw * 0.5f;
            float sinYawOver2 = (float)Math.Sin((double)yawOver2);
            float cosYawOver2 = (float)Math.Cos((double)yawOver2);
            Quaternion result;

            //s1 s2 c3 +c1 c2 s3
            result.X = sinYawOver2 * sinPitchOver2 * sinRollOver2 + cosYawOver2 * cosPitchOver2 * cosRollOver2;

            //y = s1 c2 c3 + c1 s2 s3
            result.Y = cosYawOver2 * cosPitchOver2 * sinRollOver2 - sinYawOver2 * sinPitchOver2 * cosRollOver2;

            //c1 s2 c3 - s1 c2 s3
            result.Z = cosYawOver2 * sinPitchOver2 * cosRollOver2 + sinYawOver2 * cosPitchOver2 * sinRollOver2;

            //c1 c2 c3 - s1 s2 s3
            result.W = sinYawOver2 * cosPitchOver2 * cosRollOver2 - cosYawOver2 * sinPitchOver2 * sinRollOver2;
            return result;


            /*http://www.euclideanspace.com/maths/geometry/rotations/conversions/eulerToQuaternion/
            
            w = c1 c2 c3 - s1 s2 s3   1 = heading (y - yaw) 2 = attitude (z - pitch) 3 = bank (x - roll)
            x = s1 s2 c3 +c1 c2 s3
            y = s1 c2 c3 + c1 s2 s3
            z = c1 s2 c3 - s1 c2 s3

            where:

                c1 = cos(heading / 2)
                c2 = cos(attitude / 2)
                c3 = cos(bank / 2)
                s1 = sin(heading / 2)
                s2 = sin(attitude / 2)
                s3 = sin(bank / 2)

             */



        }


    }
}
