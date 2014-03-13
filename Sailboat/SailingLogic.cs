using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailboat
{
    class SailingLogic
    {
        SailingSimulator mySailboat;
        public SailingLogic(SailingSimulator mySailboat)
        {
            this.mySailboat = mySailboat;
        }
        enum SailingTechnique { Setup, CloseHaul, Direct, Tack };
        SailingTechnique Attack = SailingTechnique.Setup;
        enum DirectionType { Port, Starboard };
        DirectionType AttackDirection = DirectionType.Port;
        private const double TackWidth = 2.0;
        public void Reset()
        {
            Attack = SailingTechnique.Setup;
        }
        public void Logic()
        {
            // The wind wrapped 180 for when waypoint into the wind
            double rotateWind = myMath.Wrap(mySailboat.WindDirection + Math.PI, 2 * Math.PI);            
            switch (Attack)
            {
                case SailingTechnique.Setup:
                    // Tack
                    if (Math.Abs(rotateWind - mySailboat.Heading) < (Math.PI / 6.0))
                    {
                        Attack = SailingTechnique.CloseHaul;
                        mySailboat.Bearing = rotateWind + TackDirection(rotateWind);
                        Direction(mySailboat.Bearing, mySailboat.Orientation);
                        //Bearing = Heading;
                        //Bearing = TackDirection(rotateWind, Orientation);
                    }
                    // With the wind
                    else
                    {
                        Attack = SailingTechnique.Direct;
                        Direction(mySailboat.Heading, mySailboat.Orientation);
                        mySailboat.Bearing = mySailboat.Heading;
                    }
                    // TODO Reaching case
                    break;
                case SailingTechnique.CloseHaul:
                    double distanceToTarget = Math.Sqrt(Math.Pow(mySailboat.Lattitude - mySailboat.HeadingY, 2) + Math.Pow(mySailboat.Longitude - mySailboat.HeadingX, 2)) / 10.0;
                    double distanceAfterMoving = Math.Sqrt(Math.Pow((mySailboat.Lattitude - Math.Cos(mySailboat.Orientation)) - mySailboat.HeadingY, 2) + Math.Pow((mySailboat.Longitude - Math.Sin(mySailboat.Orientation)) - mySailboat.HeadingX, 2)) / 10.0;
                    double Adjustment = Math.Sin(mySailboat.Heading-rotateWind);
                    double tempY = mySailboat.Lattitude - (Math.Cos(mySailboat.Orientation));
                    double tempX = mySailboat.Longitude - Math.Sin(mySailboat.Orientation);
                    if (Math.Abs(rotateWind - mySailboat.Heading) > Math.PI / 5)
                    {
                        Attack = SailingTechnique.Setup;
                    }
                    else if(Math.Abs(distanceToTarget*Adjustment)>TackWidth)
                        //&& Math.Abs((distanceToTarget-distanceAfterMoving)*Adjustment))
                    {
                        mySailboat.Bearing = rotateWind - TackDirection(rotateWind);
                        Direction(mySailboat.Bearing, mySailboat.Orientation);
                        Attack = SailingTechnique.Tack;
                    }
                    break;
                case SailingTechnique.Tack:
                    if (Math.Abs(mySailboat.Bearing-mySailboat.Orientation) < Math.PI/180)
                        Attack = SailingTechnique.Setup;
                    break;
                case SailingTechnique.Direct:
                    if (Math.Abs(mySailboat.Heading - mySailboat.Bearing) > Math.PI / 180)
                    {
                        Attack = SailingTechnique.Setup;
                    }
                    break;
            }
            // Check if target reached
            if (Math.Abs(mySailboat.Lattitude - mySailboat.HeadingY) > 10 || Math.Abs(mySailboat.Longitude - mySailboat.HeadingX) > 10)
            {
                if (Math.Abs(mySailboat.Orientation - mySailboat.Bearing) > Math.PI / 180)
                {
                    mySailboat.Orientation += Math.PI * (1 - 2 * (int)AttackDirection) / 180.0;
                }
                mySailboat.Lattitude = mySailboat.Lattitude - (Math.Cos(mySailboat.Orientation));
                mySailboat.Longitude = mySailboat.Longitude - Math.Sin(mySailboat.Orientation);
                mySailboat.DrawBoat();
            }
            // Target reached
            // TODO Go to next waypoint
            else
            { mySailboat.OpModeChanged(true); }
        }
        // Determine which direction is closest to target
        void Direction(double head, double orient)
        {
            double Rotation = myMath.Wrap(head - orient, 2 * Math.PI);
            if (Rotation < Math.PI)
                AttackDirection = DirectionType.Port;
            else
                AttackDirection = DirectionType.Starboard;
        }
        double TackDirection(double wind)
        {
            double TackStarboard = myMath.Wrap((wind + Math.PI / 6) - mySailboat.Orientation, 2 * Math.PI);
            double TackPort = myMath.Wrap((wind - Math.PI / 6) - mySailboat.Orientation, 2 * Math.PI);
            if (TackStarboard >= Math.PI)
                TackStarboard = 2 * Math.PI - TackStarboard;
            if (TackPort >= Math.PI)
                TackPort = 2 * Math.PI - TackPort;
            if (TackPort < TackStarboard)
                return - Math.PI / 6;
            else
                return Math.PI / 6;
        }
    }
}
