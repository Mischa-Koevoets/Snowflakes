using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcMan
{
    /// <summary>
    /// The Program class
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main method
        /// </summary>
        /// <param name="args"></param>
        static public void Main(String[] args)
        {
            // Clear the console, hide cursor, set foreground color to white
            Console.Clear();
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.White;
            
            // Set initial positions
            int top = 0;
            int left = 12;
            int top2 = 1;
            int left2 = 9;
            // Set fields for timing
            TimeSpan delay = new TimeSpan(0, 0, 0, 0, 1000);
            TimeSpan timeElapsed = new TimeSpan(0);
            TimeSpan delay2 = new TimeSpan(0, 0, 0, 0, 1000);
            TimeSpan timeElapsed2 = new TimeSpan(0);
            // Set initial values for start- and endTime
            DateTime startTime = DateTime.Now;
            DateTime endTime = DateTime.Now;

            // Do as long as the game is running
            while (true)
            {

                // Calculate how long previous update took
                TimeSpan currentFrame = endTime - startTime;
                timeElapsed += currentFrame;
                timeElapsed2 += currentFrame;
              
                // Register start of "update"
                startTime = DateTime.Now;

                if ( timeElapsed > delay)
                {
                    // reset timer
                    timeElapsed -= delay;

                    // Clear current position
                    Console.SetCursorPosition(left, top);
                    Console.Write(' ');                    

                    // increase top
                    top++;

                    // Check if we are at the bottom
                    if (top > 24)
                    {
                        // reset top
                        top = 0;
                    }

                    // SNowflake has moved, redraw
                    Console.SetCursorPosition(left, top);
                    Console.Write('*');

                }
                if ( timeElapsed2 > delay2)
                {
                    // reset timer
                    timeElapsed2 -= delay2;

                    // Clear current position
                    Console.SetCursorPosition(left2, top2);
                    Console.Write(' ');                    

                    // increase top
                    top2++;

                    // Check if we are at the bottom
                    if (top2 > 24)
                    {
                        // reset top
                        top2 = 0;
                    }

                    // SNowflake has moved, redraw
                    Console.SetCursorPosition(left2, top2);
                    Console.Write('*');

                }
                endTime = DateTime.Now;

            }
        }
    }
}