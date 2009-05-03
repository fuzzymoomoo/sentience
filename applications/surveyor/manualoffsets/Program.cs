﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using sluggish.utilities;
using System.Windows.Forms;

namespace manualoffsets
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // extract command line parameters
            ArrayList parameters = commandline.ParseCommandLineParameters(args, "-", GetValidParameters());

            string left_image_filename = commandline.GetParameterValue("left", parameters);
            string right_image_filename = commandline.GetParameterValue("right", parameters);

            bool parameters_exist = false;

            float offset_x = 0;
            string offset_x_str = commandline.GetParameterValue("offsetx", parameters);
            if (offset_x_str != "")
            {
                offset_x = Convert.ToSingle(offset_x_str);
                parameters_exist = true;
            }

            float offset_y = 0;
            string offset_y_str = commandline.GetParameterValue("offsety", parameters);
            if (offset_y_str != "")
            {
                offset_y = Convert.ToSingle(offset_y_str);
                parameters_exist = true;
            }

            float scale = 1;
            string scale_str = commandline.GetParameterValue("scale", parameters);
            if (scale_str != "")
            {
                scale = Convert.ToSingle(scale_str);
                parameters_exist = true;
            }

            frmManualOffsetCalibration frm = new frmManualOffsetCalibration(left_image_filename, right_image_filename, offset_x, offset_y, scale, parameters_exist);
            frm.ShowDialog();
        }

        /// <summary>
        /// returns a list of valid parameter names
        /// </summary>
        /// <returns>list of valid parameter names</returns>
        private static ArrayList GetValidParameters()
        {
            ArrayList ValidParameters = new ArrayList();

            ValidParameters.Add("left");
            ValidParameters.Add("right");
            ValidParameters.Add("offsetx");
            ValidParameters.Add("offsety");
            ValidParameters.Add("scale");

            return (ValidParameters);
        }
    }
}
