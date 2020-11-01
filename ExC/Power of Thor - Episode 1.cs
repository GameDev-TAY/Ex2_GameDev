using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTX = int.Parse(inputs[2]); // Thor's starting X position
        int initialTY = int.Parse(inputs[3]); // Thor's starting Y position
        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.

            string directionX = "";
            string directionY = "";
            //xLight....xT ---> T need to move West that why we promoted Thor on the X axis
            if (initialTX > lightX)
            {
                directionX = "W";
                initialTX--;
            }
            /**
                xT....xLight ---> T need to move East that why we promoted Thor on the X axis 
            */
            else if (initialTX < lightX)
            {
                directionX = "E";
                initialTX++;
            }

            /**
            yLight
            .
            .
            .
            yT 
            ---> T need to move North that why we promoted Thor on the y axis
            */
            if (initialTY > lightY)
            {
                directionY = "N";
                initialTY--;
            }
            /**   
            yT
            .
            .
            . 
            yLight
            ---> T need to move South that why we promoted Thor on the y axis
            */
            else if (initialTY < lightY)
            {
                directionY = "S";
                initialTY++;
            }

            /**If the direction is NW,NE,SW,SE The software will treat this Because we print both 
            where we go from position X and from position Y.
            If the direction is N,S,W,E Only one direction will be initialized */
            Console.WriteLine("{0}{1}", directionY, directionX);


        }
    }
}