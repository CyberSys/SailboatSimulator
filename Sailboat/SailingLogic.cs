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
        enum SailingTechnique { Setup, Tack, Direct };
        SailingTechnique Attack = SailingTechnique.Setup;
        enum DirectionType { Port, Starboard };
        DirectionType AttackDirection = DirectionType.Port;
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
                    if (Math.Abs(rotateWind - mySailboat.Heading) < (Math.PI / 6.0))
                    {
                        Attack = SailingTechnique.Tack;
                        double TackStarboard = myMath.Wrap((rotateWind + Math.PI / 6) - mySailboat.Orientation, 2 * Math.PI);
                        double TackPort = myMath.Wrap((rotateWind - Math.PI / 6) - mySailboat.Orientation, 2 * Math.PI);
                        if (TackStarboard >= Math.PI)
                            TackStarboard = 2 * Math.PI - TackStarboard;
                        if (TackPort >= Math.PI)
                            TackPort = 2 * Math.PI - TackPort;
                        if (TackPort < TackStarboard)
                            mySailboat.Bearing = rotateWind - Math.PI / 6;
                        else
                            mySailboat.Bearing = rotateWind + Math.PI / 6;
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
                case SailingTechnique.Tack:
                    if (Math.Abs(rotateWind - mySailboat.Heading) > Math.PI / 5)
                    {
                        Attack = SailingTechnique.Setup;
                    }
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
    }
}
