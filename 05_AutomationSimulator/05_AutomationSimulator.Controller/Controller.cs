using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AutomationSimulator
{
    public class Controller
    {
        static bool dontMove = false;
        static bool clc = true;
        static bool calcArriveRight = true;
        static bool calcSpeed = false;
        static bool adjustSpeed = false;
        static int arriveMiddleSensor=99999;
        static int arriveRightSensor=99999;
        static int move=99999;
        static Outputs output = new Outputs();
        public static Outputs Update(Inputs inputs)
        {
            if (inputs.PositioningEnabled == true)
            {
                Debug.WriteLine(inputs.CurrentTimeInMilliseconds.ToString());
                if (inputs.ProximitySensorLeft == true)
                {
                    output.MoveLeft = false;
                    output.MoveRight = true;
                }

                if (dontMove == false)
                    output.MoveRight = true;

                if(adjustSpeed==false)
                    output.MoveSpeed = Configuration.MotorSpeedFast;

                    if (inputs.ProximitySensorMiddle == true)
                    {
                        output.MoveSpeed = Configuration.MotorSpeedSlow;
                        calcSpeed = true;
                        adjustSpeed = true;
                    }

                    if(calcSpeed)
                    {
                        if(inputs.ProximitySensorMiddle==false)
                        {
                            arriveMiddleSensor = (int)inputs.CurrentTimeInMilliseconds;
                            calcSpeed = false;
                        }
                    }
                   
                    if (inputs.ProximitySensorRight == true)
                    {
                        if(calcArriveRight)
                        {
                            arriveRightSensor = (int)inputs.CurrentTimeInMilliseconds;
                            move = (int)(arriveRightSensor + ((arriveRightSensor - arriveMiddleSensor) / 2) + ((arriveRightSensor -arriveMiddleSensor) * 1E-3) * (Configuration.MotorSpeedSlow));
                            calcArriveRight = false;
                        }
                        dontMove = true;
                        output.MoveRight = false;
                        output.MoveLeft = true;
                    }

                    if (inputs.CurrentTimeInMilliseconds >= (double)(move))
                    {
                        output.MoveSpeed = 0;
                    }
            }
            else
            {
                output.MoveSpeed = 0;
            }
            return output;
        }
    }
}
