using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sailboat
{
    public partial class SailingSimulator : Form
    {
        bool HeadingType = false;
        bool OpMode = true;
        SailingLogic myLogic;
        public SailingSimulator()
        {
            InitializeComponent();
            myLogic = new SailingLogic(this);
            HeadingTypeChanged(rbHeadCoordinates, EventArgs.Empty);
            OpModeChanged(rbOpSetup, EventArgs.Empty);

        }
        private void HeadingTypeChanged(object sender, EventArgs e)
        {
            RadioButton c = (RadioButton)sender;
            HeadingType = rbHeadCoordinates.Equals(c);
            rbHeadCoordinates.Checked = HeadingType;
            pnlHeadCoordinates.Enabled = HeadingType;
            rbHeadDirection.Checked = !HeadingType;
            pnlHeadDirection.Enabled = !HeadingType;
        }

        private void OpModeChanged(object sender, EventArgs e)
        {            
            RadioButton c = (RadioButton)sender;
            OpModeChanged(rbOpSetup.Equals(c));

        }
        public void OpModeChanged(bool mode)
        {
            OpMode = mode;
            rbOpSetup.Checked = OpMode;
            pnlOpMode.Enabled = OpMode;
            Pulse.Enabled = !OpMode;
            if (OpMode)
            {
                myLogic.Reset();

            }
        }
        Bitmap bmp = new Bitmap(1000,1000);
        int i = 0;
        private void UpdateBoat(object sender, EventArgs e)
        {
            i++;
            double dx = HeadingX - Longitude;
            double dy = Lattitude-HeadingY;
            if (HeadingType)
                Heading = ((Math.Atan((dy) / (dx)) + Math.PI * Convert.ToInt64((dy < 0 && dx < 0) || (dy > 0 && dx < 0)))-(Math.PI/2));
            if(OpMode)
            {
                DrawBoat();
            }
        }
        public void DrawBoat()
        {
            Pen myRed = new Pen(Color.Red, 4);
            Pen myBlack = new Pen(Color.Black, 6);
            Graphics g = Graphics.FromImage(bmp);
            if(cboxClear.Checked==false)
                g.Clear(Color.White);
            //Boat
            Point[] boat = new Point[6];
            boat[0] = new Point((int)(Longitude + (30 * Math.Sin(Orientation))), (int)(Lattitude + (30 * Math.Cos(Orientation))));
            boat[1] = new Point((int)(Longitude + (20 * Math.Sin(Orientation + (Math.PI / 6.0)))), (int)(Lattitude + (20 * Math.Cos(Orientation + (Math.PI / 6.0)))));
            boat[2] = new Point((int)(Longitude - (20 * Math.Sin(Orientation - (Math.PI / 9.0)))), (int)(Lattitude - (20 * Math.Cos(Orientation - (Math.PI / 9.0)))));
            boat[3] = new Point((int)(Longitude - (40 * Math.Sin(Orientation))), (int)(Lattitude - (40 * Math.Cos(Orientation))));
            boat[4] = new Point((int)(Longitude - (20 * Math.Sin(Orientation + (Math.PI / 9.0)))), (int)(Lattitude - (20 * Math.Cos(Orientation + (Math.PI / 9.0)))));
            boat[5] = new Point((int)(Longitude + (20 * Math.Sin(Orientation - (Math.PI / 6.0)))), (int)(Lattitude + (20 * Math.Cos(Orientation - (Math.PI / 6.0)))));
            g.DrawClosedCurve(myRed, boat, 0.2F, System.Drawing.Drawing2D.FillMode.Winding);
            //Sail           
            g.DrawLine(myBlack, (int)(Longitude - 20 * Math.Sin(Orientation)), (int)(Lattitude - 20 * Math.Cos(Orientation)), (int)(Longitude - 20 * Math.Sin(Orientation) - 40 * Math.Sin(MainSail - Orientation)), (int)(Lattitude - 20 * Math.Cos(Orientation) + 40 * Math.Cos(MainSail - Orientation)));
            //Rudder
            g.DrawLine(myBlack, (int)(Longitude + 30 * Math.Sin(Orientation)), (int)(Lattitude + 30 * Math.Cos(Orientation)), (int)(Longitude + 30 * Math.Sin(Orientation) - 20 * Math.Sin(Rudder - Orientation)), (int)(Lattitude + 30 * Math.Cos(Orientation) + 20 * Math.Cos(Rudder - Orientation)));
            //WindDirection
            g.DrawLine(myBlack, (int)(975 - 25 * Math.Sin(WindDirection)), (int)(25 - 25 * Math.Cos(WindDirection)), (int)(975 + 25 * Math.Sin(WindDirection - Math.PI / 12.0)), (int)(25 + 25 * Math.Cos(WindDirection - Math.PI / 12.0)));
            g.DrawLine(myBlack, (int)(975 - 25 * Math.Sin(WindDirection)), (int)(25 - 25 * Math.Cos(WindDirection)), (int)(975 + 25 * Math.Sin(WindDirection + Math.PI / 12.0)), (int)(25 + 25 * Math.Cos(WindDirection + Math.PI / 12.0)));
            //Waypoint
            g.DrawEllipse(myRed, (int)(HeadingX - 15), (int)(HeadingY - 15), 30, 30);

            pboxOcean.BackgroundImage = (Image)bmp.Clone();
            myRed.Dispose();
            myBlack.Dispose();
            g.Dispose();
        }
        public double Longitude
        {
            get 
            {
                return (double)(nudStatsLongitude.Value * 10);
            }
            set
            {
                nudStatsLongitude.Value = (decimal)(value / 10.0);
            }
        }
        public double Lattitude
        {
            get
            {
                return (double)(1000-nudStatsLattitude.Value * 10);
            }
            set
            {
                nudStatsLattitude.Value = (decimal)((1000 - value) / 10.0);
            }
        }
        public double Orientation
        {
            get
            {
                return myMath.DegreesToRadians((double)nudStatsDegrees.Value);
            }
            set
            {
                nudStatsDegrees.Value = (decimal)myMath.RadiansToDegrees(value);
            }
        }
        public double MainSail
        {
            get
            {
                return myMath.DegreesToRadians((double)nudSailMain.Value);
            }
            set
            {
                nudSailMain.Value = (decimal)myMath.RadiansToDegrees(value);
            }
        }
        public double Rudder
        {
            get
            {
                return myMath.DegreesToRadians((double)nudRudderDirection.Value);
            }
            set
            {
                nudRudderDirection.Value = (decimal)myMath.RadiansToDegrees(value);
            }
        }        
        public double WindDirection
        {
            get
            {
                return myMath.DegreesToRadians((double)nudWindDirection.Value);
            }
            set
            {
                nudWindDirection.Value = (decimal)myMath.RadiansToDegrees(value);
            }
        }
        public double WindSpeed
        {
            get
            {
                return (double)nudWindMagnitude.Value;
            }
            set
            {
                nudWindMagnitude.Value = (decimal)value;
            }
        }
        public double Heading
        {
            get
            {
                return myMath.DegreesToRadians((double)nudHeadDegrees.Value);
            }
            set
            {               
                nudHeadDegrees.Value = (decimal)myMath.RadiansToDegrees(value);
            }
        }
        public double HeadingX
        {
            get
            {
                return (double)(nudHeadLongitude.Value*10);
            }
            set
            {
                nudHeadLongitude.Value = (decimal)(value / 10.0);
            }
        }
        public double HeadingY
        {
            get
            {
                return (double)(1000 - nudHeadLattitude.Value * 10);
            }
            set
            {
                nudHeadLattitude.Value = (decimal)((1000 - value) / 10.0);
            }
        }
        public double Bearing
        {
            get
            {
                return myMath.DegreesToRadians((double)nudBearing.Value);
            }
            set
            {
                nudBearing.Value = (decimal)myMath.RadiansToDegrees(value);
            }
        }
        private void Logic(object sender, EventArgs e)
        {
            myLogic.Logic();
        }

    }
}
