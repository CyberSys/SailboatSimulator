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
        private const double TackWidth = 5.0;
        public void Reset()
        {
            Attack = SailingTechnique.Setup;
        }
        public void Logic()
        {
            double rotateWind = myMath.Wrap(mySailboat.WindDirection + Math.PI, 2 * Math.PI);            
            switch (Attack)
            {
                case SailingTechnique.Setup:
                    if (Invert(rotateWind - mySailboat.Heading,2*Math.PI) < (Math.PI / 6.0))
                    {
                        Attack = SailingTechnique.CloseHaul;
                        mySailboat.Bearing = rotateWind + TackDirection(rotateWind);
                        Direction(mySailboat.Bearing, mySailboat.Orientation);
                        //Bearing = Heading;
                        //Bearing = TackDirection(rotateWind, Orientation);
                    }
                    else
                    {
                        Attack = SailingTechnique.Direct;
                        Direction(mySailboat.Heading, mySailboat.Orientation);
                        mySailboat.Bearing = mySailboat.Heading;
                    }
                    break;
                case SailingTechnique.CloseHaul:
                    double distanceToTarget = Math.Sqrt(Math.Pow(mySailboat.Lattitude - mySailboat.HeadingY, 2) + Math.Pow(mySailboat.Longitude - mySailboat.HeadingX, 2)) / 10.0;
                    double distanceAfterMoving = Math.Sqrt(Math.Pow((mySailboat.Lattitude - Math.Cos(mySailboat.Orientation)) - mySailboat.HeadingY, 2) + Math.Pow((mySailboat.Longitude - Math.Sin(mySailboat.Orientation)) - mySailboat.HeadingX, 2)) / 10.0;
                    double Adjustment = Math.Sin(mySailboat.Heading-rotateWind);
                    double dx = mySailboat.HeadingX - (mySailboat.Longitude - Math.Sin(mySailboat.Orientation));
                    double dy = (mySailboat.Lattitude - (Math.Cos(mySailboat.Orientation))) - mySailboat.HeadingY;
                    double tempTheta = ((Math.Atan((dy) / (dx)) + Math.PI * Convert.ToInt64((dy < 0 && dx < 0) || (dy > 0 && dx < 0))) - (Math.PI / 2));
                    double Adjustment2 = Math.Sin(tempTheta-rotateWind);
                    double Exit = rotateWind - mySailboat.Heading;

                    if (Invert(rotateWind - mySailboat.Heading,2*Math.PI) > Math.PI / 5)
                    {
                        Attack = SailingTechnique.Setup;
                    }
                    else if(Math.Abs(distanceToTarget*Adjustment)>TackWidth
                            && Math.Abs(distanceToTarget*Adjustment)<Math.Abs(distanceAfterMoving*Adjustment2))
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
            else
            { mySailboat.OpModeChanged(true); }
        }
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
            double TackStarboard = Invert((wind + Math.PI / 6) - mySailboat.Orientation, 2 * Math.PI);
            double TackPort = Invert((wind - Math.PI / 6) - mySailboat.Orientation, 2 * Math.PI);
            //if (TackStarboard >= Math.PI)
            //    TackStarboard = 2 * Math.PI - TackStarboard;
            //Invert(TackStarboard, Math.PI);
            //Invert(TackPort, Math.PI);
            //if (TackPort >= Math.PI)
            //    TackPort = 2 * Math.PI - TackPort;
            if (TackPort < TackStarboard)
                return - Math.PI / 6;
            else
                return Math.PI / 6;
        }
        double Invert(double x,double length)
        {
            x = myMath.Wrap(x, length);
            if(x>=(length/2.0))
                return length - x;
            return x;
        }
    }
}
