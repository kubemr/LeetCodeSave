using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.Stack
{
    public class AsteroidCollision
    {
        public static string ExecuteSolution(int[] asteroids)
        {
            Console.WriteLine("25: Asteroid Collision");
            Console.Write("Asteroid: [");
            foreach (var asteroid in asteroids)
            {
                Console.Write(asteroid + "; ");
            }
            Console.WriteLine("]");


            int[] results = AsteroidCollisionA(asteroids);
            string output = "[ ";
            foreach (var result in results)
            {
                output += $"{result}; ";
            }
            output += "]";
            return output;
        }

        public static int[] AsteroidCollisionA(int[] asteroids)
        {
            int prev = -1;
            for (int i = 0; i < asteroids.Length; i++) {
                bool notSame = true;
                if (asteroids[i] > 0) {
                    asteroids[++prev] = asteroids[i];
                } else {
                    while (prev >= 0 && asteroids[prev] > 0) {
                        if (asteroids[prev] < -asteroids[i]) {
                            prev--;
                        } else if (asteroids[prev] == -asteroids[i]) {
                            prev--;
                            notSame = false;
                            break;
                        } else {
                            break;
                        }
                    }

                    if (notSame && (prev < 0 || asteroids[prev] < 0)) {
                        asteroids[++prev] = asteroids[i];
                    }
                }
            }
            int[] result = new int[prev + 1];
            Array.Copy(asteroids, result, prev + 1);
            return result;
        }
    }
}
